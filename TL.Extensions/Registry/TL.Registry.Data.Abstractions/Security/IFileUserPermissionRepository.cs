using System;
using TL.Engine.SDK.Repositories;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.Abstractions.Security
{
    public interface IFileUserPermissionRepository : IEntityComparableRepository<FileUserPermission, (Guid, Guid)>
    {
    }
}
