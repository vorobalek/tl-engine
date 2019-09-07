using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Registry.Data.Entities.Core
{
    public enum RegistryType
    {
        Public,
        Private
    }

    public class Registry : EntityComparableStored<Guid>
    {
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public RegistryType Type { get; set; }

        public Guid RootId { get; set; }

        public virtual Folder Root { get; set; }
    }
}
