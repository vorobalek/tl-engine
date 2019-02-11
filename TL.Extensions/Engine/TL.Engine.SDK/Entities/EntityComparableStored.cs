using System;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityComparableStored<TKey> : EntityStored, IEntityComparableStored<TKey> where TKey : IComparable
    {
        public EntityComparableStored() : base()
        {
        }

        public virtual TKey Id { get; set; }
    }
}
