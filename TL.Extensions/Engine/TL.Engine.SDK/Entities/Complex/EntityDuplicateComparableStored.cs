using System;
using System.Collections.Generic;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityDuplicateComparableStored<TKey> : EntityComparableStored<TKey>, IEntityDuplicate<TKey>
        where TKey : struct, IComparable
    {
        public EntityDuplicateComparableStored() : base()
        {
            Duplicates = new HashSet<IEntityDuplicate<TKey>>();
        }

        public virtual TKey? OriginalId { get; set; }

        public virtual IEntityDuplicate<TKey> Original { get; set; }

        public virtual IEnumerable<IEntityDuplicate<TKey>> Duplicates { get; set; }
    }
}
