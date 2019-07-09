using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Services;

namespace TL.Engine.SDK.Managers
{
    /// <summary>
    /// Абстрактная реализация менеджера элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом, отслеживающих отметки времени создания и последнего изменения.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа сущности.</typeparam>
    /// <seealso cref="EntityManager{TEntity}" />
    /// <seealso cref="IEntityComparableStoredManager{TEntity, TKey}" />
    public abstract class EntityComparableStoredManager<TEntity, TKey> : EntityManager<TEntity>, IEntityComparableStoredManager<TEntity, TKey>
        where TEntity : class, IEntityComparable<TKey>, IEntityStored
        where TKey : IComparable
    {
        public EntityComparableStoredManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <param name="loadDeleted">Если <c>true</c>, будут загружены также удалённые сущности.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public virtual TEntity Get(TKey key, bool loadDeleted = false)
        {
            return Get(e => e.Id.Equals(key), loadDeleted);
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
            return GetOrCreate(e => e.Id.Equals(key), loadDeleted, entity, cacheOnly);
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
            return UpdateOrCreate(e => e.Id.Equals(key), entity, cacheOnly);
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
            return UpdateOrCreate(e => e.Id.Equals(entity.Id), entity, cacheOnly);
        }
    }
}
