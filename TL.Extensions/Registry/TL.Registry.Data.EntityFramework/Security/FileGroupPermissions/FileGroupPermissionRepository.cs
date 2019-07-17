using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Abstractions.Security;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FileGroupPermissions
{
    public class FileGroupPermissionRepository : EntityComparableRepository<FileGroupPermission, (Guid, Guid)>, IFileGroupPermissionRepository
    {
    }
}
