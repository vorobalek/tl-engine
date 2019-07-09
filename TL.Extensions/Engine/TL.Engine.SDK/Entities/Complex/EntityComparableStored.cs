using System;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Абстрактная реализация элементарной сущности <see cref="Entity"/> с первичным ключом, отслеживающей отметки времени создания и последнего изменения.
    /// </summary>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="EntityStored" />
    /// <seealso cref="IEntityComparable{TKey}" />
    public abstract class EntityComparableStored<TKey> : EntityStored, IEntityComparable<TKey> where TKey : IComparable
    {
        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public virtual TKey Id { get; set; }
    }
}
