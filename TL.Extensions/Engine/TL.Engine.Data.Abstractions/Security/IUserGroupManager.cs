using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IUserGroupManager : IEntityComparableManager<UserGroup, (Guid, Guid)>
    {
    }
}