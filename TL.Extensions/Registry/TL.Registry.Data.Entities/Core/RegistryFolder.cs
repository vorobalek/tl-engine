using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.Entities.Core
{
    public class RegistryFolder : EntityComparableStored<Guid>
    {
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public string Name { get; set; }

        public Guid? ParantId { get; set; }

        public virtual RegistryFolder Parant { get; set; }

        public virtual IEnumerable<RegistryFolder> Folders { get; set; }

        public virtual IEnumerable<RegistryFile> Files { get; }

        public virtual IEnumerable<RegistryFolderUserPermission> UserPermissions { get; set; }

        public virtual IEnumerable<RegistryFolderGroupPermission> GroupPermissions { get; set; }
    }
}