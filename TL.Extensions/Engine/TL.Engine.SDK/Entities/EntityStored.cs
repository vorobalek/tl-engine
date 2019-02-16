using System;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityStored : IEntityStored
    {
        public virtual DateTime CreationDate { get; set; }

        public virtual DateTime ModifiedDate { get; set; }
    }
}
