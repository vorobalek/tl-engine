using System;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Интерфейс элементарной сущности <see cref="IEntity"/> с первичным ключом.
    /// </summary>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="IEntity" />
    public interface IEntityComparable<TKey> : IEntity
        where TKey : IComparable
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        TKey Id { get; set; }
    }
}
