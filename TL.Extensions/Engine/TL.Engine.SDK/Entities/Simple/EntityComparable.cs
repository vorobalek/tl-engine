using System;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityComparable<TKey> : Entity, IEntityComparable<TKey>
        where TKey : IComparable
    {
        public EntityComparable() : base()
        {
        }

        public virtual TKey Id { get; set; }
    }
}
