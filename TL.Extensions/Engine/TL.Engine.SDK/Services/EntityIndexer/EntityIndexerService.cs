using ExtCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Structures;

namespace TL.Engine.SDK.Services
{
    public class EntityIndexerService : IEntityIndexerService
    {
        ILogger Logger { get; }

        IServiceProvider ServiceProvider { get; }

        ConcurrentDictionary<Type, Trie> Cache { get; set; }

        public EntityIndexerService(ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
        {
            Logger = loggerFactory.CreateLogger<EntityIndexerService>();
            ServiceProvider = serviceProvider;
        }

        public IEnumerable<object> Find(string query, int count = 0)
        {
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

        public IEnumerable<object> Find<TEntity>(string query, int count = 0)
        {
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

        public void Reset()
        {
            Logger.TLogWarning($"Reset Service");
            var entityTypes = ExtensionManager
                .GetImplementations<IEntity>()
                .Where(t => !t.IsAbstract);

            Cache = new ConcurrentDictionary<Type, Trie>(entityTypes.Select(t => new KeyValuePair<Type, Trie>(t, Trie.Create())));

            entityTypes
                .ToList()
                .ForEach(entityType =>
                {
                    Logger.TLogInformation($"Indexing {entityType} running...");
                    var managerType = ExtensionManager
                            .GetImplementations<IEntityManager>()
                            .FirstOrDefault(rt => !rt.IsAbstract
                            && ActivatorUtilities.GetServiceOrCreateInstance(ServiceProvider, rt) is IEntityManager manager
                            && manager.TargetType == entityType);
                    if (managerType != null)
                    {
                        if (ActivatorUtilities.GetServiceOrCreateInstance(ServiceProvider, managerType.GetInterfaces().Last()) is IEntityManager managerInstance)
                        {
                            var entities = managerInstance.GetAll(loadDeleted: true);
                            foreach (var entity in entities)
                            {
                                Add(entity);
                            }
                        }
                    }
                    Logger.TLogInformation($"Indexing {entityType} finished...");
                });
        }

        internal class EntityStringProperty
        {
            public string Name { get; }
            public string Value { get; }
            public EntityStringProperty(string name, string value)
            {
                Name = name;
                Value = value;
            }
        }

        internal class EntityWithStringProperty
        {
            public IEntity Entity { get; }
            public string Type { get; }
            public EntityStringProperty Property { get; }
            public EntityWithStringProperty(IEntity entity, EntityStringProperty property)
            {
                Entity = entity;
                Type = entity.GetType().GetFullName();
                Property = property;
            }
        }

        public void Add<TEntity>(TEntity entity)
        {
            var stringProperties = entity
                                    .GetType()
                                    .GetProperties()
                                    .Where(pi => pi.PropertyType == typeof(string) && pi.GetGetMethod() != null)
                                    .Select(pi => new EntityStringProperty(pi.Name, pi.GetGetMethod().Invoke(entity, null) as string ?? ""));

            foreach (var stringProperty in stringProperties)
            {
                if (stringProperty.Value is string value)
                {
                    Cache[entity.GetType()].Add(value, new EntityWithStringProperty(entity as IEntity, stringProperty));
                }
            }
        }

        public void Update<TEntity>(TEntity oldEntity, TEntity newEntity)
        {
            throw new NotImplementedException();
        }

        public void Remove<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
