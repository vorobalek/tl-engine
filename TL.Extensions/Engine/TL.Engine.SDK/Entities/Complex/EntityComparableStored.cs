using System;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityComparableStored<TKey> : EntityStored, IEntityComparable<TKey> where TKey : IComparable
    {
        public virtual TKey Id { get; set; }
    }
}
