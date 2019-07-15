using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    /// <summary>
    /// Интерфейс репозитория элементарных сущностей <typeparamref name="TEntity"/> с первичным ключом <typeparamref name="TKey"/>.
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="IEntityRepository{TEntity}" />
    public interface IEntityComparableRepository<TEntity, TKey> : IEntityRepository<TEntity>
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
        TEntity Get(TKey key);
    }
}
