using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Repositories;
using TL.Engine.SDK.Services;
using TL.Engine.SDK.Types;
using TL.Engine.SDK.Types.Enums;

namespace TL.Engine.SDK.Managers
{
    /// <summary>
    /// Абстрактная реализация менеджера элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом, отслеживающих отметки времени создания и последнего изменения.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа сущности.</typeparam>
    /// <seealso cref="EntityManager{TEntity}" />
    /// <seealso cref="IEntityComparableManager{TEntity, TKey}" />
    public abstract class EntityComparableManager<TEntity, TKey> : EntityManager<TEntity>, IEntityComparableManager<TEntity, TKey>
        where TEntity : class, IEntityComparable<TKey>
        where TKey : IComparable
    {
        public EntityComparableManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity GetByKey(TKey key)
        {
            return Storage.GetRepository<IEntityComparableRepository<TEntity, TKey>>().Get(key);
        }

        /// <summary>
        /// Получить все экземпляры сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу
        /// </summary>
        /// <param name="keys">Значения первичного ключа.</param>
        /// <returns>
        /// Экземпляры отслеживаемой сущности.
        /// </returns>
        public virtual IEnumerable<TEntity> GetByKeyAll(params TKey[] keys)
        {
            return Storage.GetRepository<IEntityComparableRepository<TEntity, TKey>>().GetAll(keys);
        }

        /// <summary>
        /// Получить объекты сущности <typeparamref name="TEntity" /> к которым есть доступ у субъекта типа <typeparamref name="TSubject" />
        /// </summary>
        /// <typeparam name="TSubject">Тип сущности субъекта.</typeparam>
        /// <typeparam name="TSubjectKey">Тип первичного ключа сущности субъекта.</typeparam>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> GetAllowedFor<TSubject, TSubjectKey>(TSubject subject)
            where TSubject : class, IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable
        {
            var permissionType = Activator.GetInstance<Permission<TSubject, TSubjectKey, TEntity, TKey>>().GetType();
            var permissionRawRepository = Storage.GetEntityRepository(Activator, permissionType);
            var predicateGet = new Func<Permission<TSubject, TSubjectKey, TEntity, TKey>, bool>((permission) =>
            {
                return permission.SubjectId.Equals(subject.Id) && permission.Mode >= AccessMode.Read;
            });
            dynamic permissionRepository = permissionRawRepository;
            var allowedEntityIds = permissionRepository.GetAll(predicateGet) as IEnumerable<Permission<TSubject, TSubjectKey, TEntity, TKey>>;
            var result = GetByKeyAll(allowedEntityIds.Select(e => e.ObjectId).ToArray());
            return result;
        }

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу или создать новый в хранилище.
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity GetOrCreate(TKey key, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false)
        {
            TEntity existedEntity = GetByKey(key);
            if (existedEntity == null)
            {
                return Create(entity, cacheOnly);
            }
            return existedEntity;
        }

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу или создать новый в хранилище.
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity UpdateOrCreate(TKey key, TEntity entity = null, bool cacheOnly = false)
        {
            TEntity existedEntity = GetByKey(key);
            if (existedEntity == null)
            {
                return Create(entity, cacheOnly);
            }
            else
            {
                if (entity == null)
                {
                    entity = CreateEmpty(cacheOnly);
                }
                entity.Id = existedEntity.Id;
                return Update(existedEntity, cacheOnly);
            }
        }

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" />, удовлетворяющей предикату или создать новый в хранилище.
        /// </summary>
        /// <param name="predicate">Предикат-функция.</param>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity UpdateOrCreate(Func<TEntity, bool> predicate, TEntity entity = null, bool cacheOnly = false)
        {
            TEntity existedEntity = Get(predicate);
            if (existedEntity == null)
            {
                return Create(entity, cacheOnly);
            }
            else
            {
                if (entity == null)
                {
                    entity = CreateEmpty(cacheOnly);
                }
                entity.Id = existedEntity.Id;
                return Update(existedEntity, cacheOnly);
            }
        }

        /// <summary>
        /// Обновить экземпляр сущности типа <typeparamref name="TEntity" /> или создать новый в хранилище.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cacheOnly">Если <c>true</c> изменения не будут отсылаться в хранилище.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity UpdateOrCreate(TEntity entity, bool cacheOnly = false)
        {
            return UpdateOrCreate(entity.Id, entity, cacheOnly);
        }
    }
}
