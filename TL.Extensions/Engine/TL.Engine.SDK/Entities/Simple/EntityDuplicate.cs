using System;
using System.Collections.Generic;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Абстрактная реализация элементарной сущности <see cref="EntityComparable{TKey}"/>, поддерживающей свои дубликаты.
    /// </summary>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="EntityComparable{TKey}" />
    /// <seealso cref="IEntityDuplicate{TKey}" />
    public abstract class EntityDuplicate<TKey> : EntityComparable<TKey>, IEntityDuplicate<TKey>
        where TKey : struct, IComparable
    {
        public EntityDuplicate() : base()
        {
            Duplicates = new HashSet<EntityDuplicate<TKey>>();
        }

        /// <summary>
        /// Внешний ключ на оригинал.
        /// </summary>
        public virtual TKey? OriginalId { get; set; }

        /// <summary>
        /// Экземпляр оригинала.
        /// </summary>
        public virtual EntityDuplicate<TKey> Original { get; set; }

        /// <summary>
        /// Колекция дубликатов.
        /// </summary>
        public virtual IEnumerable<EntityDuplicate<TKey>> Duplicates { get; set; }
    }
}
