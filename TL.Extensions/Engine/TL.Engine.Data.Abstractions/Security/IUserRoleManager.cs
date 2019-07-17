using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IUserRoleManager : IEntityComparableManager<UserRole, (Guid, Guid)>
    {
    }
}