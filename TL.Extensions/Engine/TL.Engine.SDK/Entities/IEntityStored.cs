using System;

namespace TL.Engine.SDK.Entities
{
    public interface IEntityStored : IEntity
    {
        DateTime CreationDate { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}
