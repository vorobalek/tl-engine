using System;

namespace TL.Engine.SDK.Entities
{
    public abstract class EntityStored : IEntityStored
    {
        public EntityStored()
        {
            var date = DateTime.Now.ToUniversalTime();
            CreationDate = date;
            ModifiedDate = date;
        }

        public virtual DateTime CreationDate { get; set; }

        public virtual DateTime ModifiedDate { get; set; }
    }
}
