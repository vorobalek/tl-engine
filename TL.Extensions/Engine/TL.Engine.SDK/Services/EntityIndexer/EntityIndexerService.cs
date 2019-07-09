using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Structures;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Сервис полнотекстовой индексации сущностей.
    /// </summary>
    internal class EntityIndexerService : IEntityIndexerService
    {
        ILogger Logger { get; }

        IActivatorService Activator { get; }

        ConcurrentDictionary<Type, Trie> Cache { get; set; }

        public EntityIndexerService(ILoggerFactory loggerFactory, IActivatorService activator)
        {
            Logger = loggerFactory.CreateLogger<EntityIndexerService>();
            Activator = activator;
        }

        /// <summary>
        /// Найти все сущности, содержащую хоты бы в одном из индексируемых строковых полей заданную подстроку.
        /// </summary>
        /// <param name="query">Поисковый запрос.</param>
        /// <param name="count">Максимальное количество возвращаемых объектов.</param>
        /// <returns></returns>
        public IEnumerable<object> Find(string query, int count = 0)
        {
            query = string.IsNullOrWhiteSpace(query) ? "" : query.ToLowerInvariant();
            var result = new HashSet<EntityWithStringProperty>();
            var tasks = Cache.Keys.Select(type =>
                {
                    return Task.Run(() =>
                    {
                        var typeResult = Cache[type].FindAll(query, count).Select(obj => (obj as EntityWithStringProperty));
                        return typeResult;
                    });
                })
                .ToArray();
            Task.WaitAll(tasks);
            foreach (var task in tasks)
            {
                result.UnionWith(task.Result);
            }
            return result;
        }

        /// <summary>
        /// Найти все экземпляры сущности <typeparamref name="TEntity" />, содержащую хоты бы в одном из индексируемых строковых полей заданную подстроку.
        /// </summary>
        /// <typeparam name="TEntity">Тип искомой сущности.</typeparam>
        /// <param name="query">Поисковый запрос.</param>
        /// <param name="count">Максимальное количество возвращаемых объектов.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        /// </exception>
        public IEnumerable<object> Find<TEntity>(string query, int count = 0)
        {
            query = string.IsNullOrWhiteSpace(query) ? "" : query.ToLowerInvariant();
            if (!typeof(TEntity).GetInterfaces().Contains(typeof(IEntity)))
            {
                throw new ArgumentException($"{typeof(TEntity).GetFullName()} не является производным от {typeof(IEntity).GetFullName()}");
            }
            if (!Cache.ContainsKey(typeof(TEntity)))
            {
                throw new ArgumentException($"{typeof(TEntity).GetFullName()} сущности не проиндексированы");
            }

            var result = Cache[typeof(TEntity)].FindAll(query, count).Select(obj => obj as EntityWithStringProperty);
            return result;
        }

        /// <summary>
        /// Сбросить сервис и инициализировать заново.
        /// </summary>
        public void Reset()
        {
            Logger.TLogWarning($"Reset Service");
            var entityTypes = Activator
                .GetImplementations<IEntity>()
                .Where(t => !t.IsAbstract);

            Cache = new ConcurrentDictionary<Type, Trie>(entityTypes.Select(t => new KeyValuePair<Type, Trie>(t, Trie.Create())));

            entityTypes
                .ToList()
                .ForEach(entityType =>
                {
                    if (entityType.GetFields().Where(fi => fi.GetCustomAttributes(typeof(StringIndexAttribute), inherit: true).Count() > 0).Count() > 0
                    || entityType.GetProperties().Where(pi => pi.GetCustomAttributes(typeof(StringIndexAttribute), inherit: true).Count() > 0).Count() > 0)
                    {
                        Logger.TLogInformation($"Indexing {entityType} running...");
                        var managerType = Activator
                                .GetImplementations<IEntityManager>()
                                .FirstOrDefault(rt => !rt.IsAbstract
                                && Activator.GetServiceOrCreateInstance(rt) is IEntityManager manager
                                && manager.TargetType == entityType);
                        if (managerType != null)
                        {
                            if (Activator.GetServiceOrCreateInstance(managerType.GetInterfaces().Last()) is IEntityManager managerInstance)
                            {
                                var entities = managerInstance.GetAll(loadDeleted: true);
                                foreach (var entity in entities)
                                {
                                    Add(entity);
                                }
                            }
                        }
                        Logger.TLogInformation($"Indexing {entityType} finished...");
                    }
                    else
                    {
                        Logger.TLogWarning($"An entity of type {entityType.GetFullName()} does not contain indexed fields and properties");
                    }
                });
        }

        /// <summary>
        /// Вспомогательный класс для хранения индексируемого свойства.
        /// </summary>
        internal class StringProperty
        {
            /// <summary>
            /// Имя свойства.
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// Значение свойства.
            /// </summary>
            public string Value { get; }

            public StringProperty(string name, string value)
            {
                Name = name;
                Value = value;
            }
        }

        /// <summary>
        /// Вспомогательный класс для хранения индексируемой сущности.
        /// </summary>
        internal class EntityWithStringProperty
        {
            /// <summary>
            /// Ссылка на экземпляр сущности.
            /// </summary>
            public IEntity Entity { get; }

            /// <summary>
            /// Имя типа сущности <see cref="Entity"/>.
            /// </summary>
            public string Type { get; }

            /// <summary>
            /// Индексируемое свойство.
            /// </summary>
            public StringProperty Property { get; }

            public EntityWithStringProperty(IEntity entity, StringProperty property)
            {
                Entity = entity;
                Type = entity.GetType().GetFullName();
                Property = property;
            }
        }

        /// <summary>
        /// Добавить экземпляр сущности <typeparamref name="TEntity" /> в индекс.
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности.</typeparam>
        /// <param name="entity">Экземпляр сущности.</param>
        /// <returns></returns>
        public bool Add<TEntity>(TEntity entity)
        {
            var stringProperties = 
                entity
                    .GetType()
                    .GetFields()
                    .Where(fi => fi.FieldType == typeof(string)
                    && fi.GetCustomAttributes(typeof(StringIndexAttribute), inherit: true).Count() > 0)
                    .Select(fi => new StringProperty(fi.Name, (fi.GetValue(entity) as string ?? "").ToLowerInvariant()))
                    .Concat(
                entity
                    .GetType()
                    .GetProperties()
                    .Where(pi => pi.PropertyType == typeof(string)
                    && pi.GetGetMethod() != null
                    && pi.GetCustomAttributes(typeof(StringIndexAttribute), inherit: true).Count() > 0)
                    .Select(pi => new StringProperty(pi.Name, (pi.GetGetMethod().Invoke(entity, null) as string ?? "").ToLowerInvariant())));

            if (stringProperties.Count() > 0)
            {

                foreach (var stringProperty in stringProperties)
                {
                    if (stringProperty.Value is string value)
                    {
                        Cache[entity.GetType()].Add(value, new EntityWithStringProperty(entity as IEntity, stringProperty));
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Обновить экземпляр сущности <typeparamref name="TEntity" /> в индексе.
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности.</typeparam>
        /// <param name="oldEntity">Старый экземпляр сущности.</param>
        /// <param name="newEntity">Новый экземпляр сущности.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Update<TEntity>(TEntity oldEntity, TEntity newEntity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Удалить экземпляр сущности <typeparamref name="TEntity" /> из индекса.
        /// </summary>
        /// <typeparam name="TEntity">Тип сущности.</typeparam>
        /// <param name="entity">Экземпляр сущности.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Remove<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
