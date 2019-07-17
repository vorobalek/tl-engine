using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.Entities.Core
{
    public class Folder : EntityComparableStored<Guid>
    {
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public string Name { get; set; }

        public Guid? ParantId { get; set; }

        public virtual Folder Parant { get; set; }

        public virtual IEnumerable<Registry> Registries { get; set; }

        public virtual IEnumerable<Folder> Folders { get; set; }

        public virtual IEnumerable<File> Files { get; }

        public virtual IEnumerable<FolderUserPermission> UserPermissions { get; set; }

        public virtual IEnumerable<FolderGroupPermission> GroupPermissions { get; set; }

        public virtual IEnumerable<FolderRolePermission> RolePermissions { get; set; }
    }
}