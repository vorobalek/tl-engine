using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.Abstractions.Security
{
    public interface IUserGroupRepository : IEntityComparableRepository<UserGroup, (Guid, Guid)>
    {
        IEnumerable<UserGroup> GetByRole(Group group);

        IEnumerable<UserGroup> GetByRoleId(Guid groupId);

        IEnumerable<UserGroup> GetByUser(User User);

        IEnumerable<UserGroup> GetByUserId(Guid userId);
    }
}
