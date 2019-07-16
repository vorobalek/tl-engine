using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Entities.System;
using TL.Engine.SDK.Entities;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.Entities.Core
{
    public class File : EntityComparableStored<Guid>
    {
        public Guid OwnerId { get; set; }

        public virtual User Owner { get; set; }

        public string Name { get; set; }

        public Guid FileId { get; set; }

        public virtual StaticFile StaticFile { get; set; }

        public Guid? FolderId { get; set; }

        public virtual Folder Folder { get; set; }

        public virtual IEnumerable<FileUserPermission> UserPermissions { get; set; }

        public virtual IEnumerable<FileGroupPermission> GroupPermissions { get; set; }
    }
}