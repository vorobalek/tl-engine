using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    /// <summary>
    /// Абстрактная реализация репозитория элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом <typeparamref name="TKey"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="EntityRepository{TEntity}" />
    /// <seealso cref="IEntityComparableStoredRepository{TEntity, TKey}" />
    public abstract class EntityComparableStoredRepository<TEntity, TKey> : EntityRepository<TEntity>, IEntityComparableStoredRepository<TEntity, TKey>
        where TEntity : class, IEntityComparable<TKey>, IEntityStored
        where TKey : IComparable
    {
        /// <summary>
        /// Получить экземпляр сущности типа <typeparamref name="TEntity" /> по первичному <typeparamref name="TKey" /> ключу
        /// </summary>
        /// <param name="key">Значение первичного ключа.</param>
        /// <returns>
        /// Экземпляр отслеживаемой сущности.
        /// </returns>
        public TEntity Get(TKey key)
        {
            return Get(e => e.Id.Equals(key));
        }
    }
}
