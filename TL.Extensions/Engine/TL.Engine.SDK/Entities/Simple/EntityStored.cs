using System;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityStored : Entity, IEntityStored
    {
        public virtual DateTime CreationDate { get; set; } = DateTime.Now.ToUniversalTime();

        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
