using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Abstractions.Security;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FolderRolePermissions
{
    public class FolderRolePermissionRepository : EntityComparableRepository<FolderRolePermission, (Guid, Guid)>, IFolderRolePermissionRepository
    {
    }
}
