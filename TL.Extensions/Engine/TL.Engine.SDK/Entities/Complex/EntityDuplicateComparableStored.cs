using System;
using System.Collections.Generic;

namespace TL.Engine.SDK.Entities
{
    /// <summary>
    /// Абстрактная реализация элементарной сущности <see cref="Entity"/>поддерживающей свои дубликаты, с первичным ключом, отслеживающей отметки времени создания и последнего изменения.
    /// </summary>
    /// <typeparam name="TKey">Тип первичного ключа.</typeparam>
    /// <seealso cref="EntityComparableStored{TKey}" />
    /// <seealso cref="IEntityDuplicate{TKey}" />
    public abstract class EntityDuplicateComparableStored<TKey> : EntityComparableStored<TKey>, IEntityDuplicate<TKey>
        where TKey : struct, IComparable
    {
        public EntityDuplicateComparableStored() : base()
        {
            Duplicates = new HashSet<IEntityDuplicate<TKey>>();
        }

        /// <summary>
        /// Внешний ключ на оригинал.
        /// </summary>
        public virtual TKey? OriginalId { get; set; }

        /// <summary>
        /// Экземпляр оригинала.
        /// </summary>
        public virtual IEntityDuplicate<TKey> Original { get; set; }

        /// <summary>
        /// Колекция дубликатов.
        /// </summary>
        public virtual IEnumerable<IEntityDuplicate<TKey>> Duplicates { get; set; }
    }
}
