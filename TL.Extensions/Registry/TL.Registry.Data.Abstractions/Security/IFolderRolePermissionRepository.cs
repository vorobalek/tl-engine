using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.Abstractions.Security
{
    public interface IFolderRolePermissionRepository : IEntityComparableRepository<FolderRolePermission, (Guid, Guid)>
    {
    }
}
