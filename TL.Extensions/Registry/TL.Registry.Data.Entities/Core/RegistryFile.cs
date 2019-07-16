using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Entities;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.Entities.Core
{
    public class RegistryFile : EntityComparableStored<Guid>
    {
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public string Name { get; set; }

        public Guid FileId { get; set; }

        public virtual StaticFile File { get; set; }

        public virtual IEnumerable<RegistryFileUserPermission> UserPermissions { get; set; }

        public virtual IEnumerable<RegistryFileGroupPermission> GroupPermissions { get; set; }
    }
}