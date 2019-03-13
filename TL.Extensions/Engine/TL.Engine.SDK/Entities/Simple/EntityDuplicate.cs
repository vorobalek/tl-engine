using System;
using System.Collections.Generic;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityDuplicate<TKey> : EntityComparable<TKey>, IEntityDuplicate<TKey>
        where TKey : struct, IComparable
    {
        public EntityDuplicate() : base()
        {
            Duplicates = new HashSet<EntityDuplicate<TKey>>();
        }

        public virtual TKey? OriginalId { get; set; }

        public virtual EntityDuplicate<TKey> Original { get; set; }

        public virtual IEnumerable<EntityDuplicate<TKey>> Duplicates { get; set; }
    }
}
