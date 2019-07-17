using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Abstractions.Security;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.UserPermissions
{
    public class UserPermissionRepository : EntityComparableRepository<UserPermission, (Guid, Guid)>, IUserPermissionRepository
    {
    }
}
