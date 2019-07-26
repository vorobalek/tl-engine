using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    /// <summary>
    /// Абстрактная реализация репозитория элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом <typeparamref name="TKey"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="EntityRepository{TEntity}" />
    /// <seealso cref="IEntityComparableRepository{TEntity, TKey}" />
    public abstract class EntityComparableRepository<TEntity, TKey> : EntityRepository<TEntity>, IEntityComparableRepository<TEntity, TKey>
        where TEntity : class, IEntityComparable<TKey>
        where TKey : IComparable
    {
        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public TEntity GetByKey(TKey key)
        {
            return Load(dbSet.Find(key));
        }

        /// <summary>
        /// Получить все экземпляры сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу
        /// </summary>
        /// <param name="keys">Значения первичного ключа.</param>
        /// <returns>
        /// Экземпляры отслеживаемой сущности.
        /// </returns>
        public IEnumerable<TEntity> GetByKeys(params TKey[] keys)
        {
            return keys.Select(k => GetByKey(k));
        }
    }
}
