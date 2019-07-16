using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Abstractions.Security;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FolderUserPermissions
{
    public class FolderUserPermissionRepository : EntityRepository<FolderUserPermission>, IFolderUserPermissionRepository
    {
    }
}
