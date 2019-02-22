using System;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityComparableDuplicateStored<TKey> : EntityComparableStored<TKey>, IEntityDuplicate<TKey>
        where TKey : IComparable
    {
        public EntityComparableDuplicateStored() : base()
        {
        }

        public TKey OriginalId { get; set; }

        public IEntityDuplicate<TKey> Original { get; set; }
    }
}
