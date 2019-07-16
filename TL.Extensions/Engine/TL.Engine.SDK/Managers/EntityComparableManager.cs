using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Repositories;
using TL.Engine.SDK.Services;

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
        public virtual TEntity Get(TKey key)
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
        public virtual IEnumerable<TEntity> GetAll(params TKey[] keys)
        {
            return Storage.GetRepository<IEntityComparableRepository<TEntity, TKey>>().GetAll(keys);
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
            TEntity existedEntity = Get(key, loadDeleted);
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
            TEntity existedEntity = Get(key);
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
