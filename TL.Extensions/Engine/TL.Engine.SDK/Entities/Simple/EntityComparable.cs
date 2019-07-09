using System;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Абстрактная реализация элементарной сущности <see cref="Entity"/> с первичным ключом.
    /// </summary>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="Entity" />
    /// <seealso cref="IEntityComparable{TKey}" />
    public abstract class EntityComparable<TKey> : Entity, IEntityComparable<TKey>
        where TKey : IComparable
    {
        public EntityComparable() : base()
        {
        }

        /// <summary>
        /// Первичный ключ.
        /// </summary>
        public virtual TKey Id { get; set; }
    }
}
