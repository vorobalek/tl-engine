using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Account.Data.Abstractions.Security
{
    public interface IUserGroupRepository : IEntityRepository<UserGroup>
    {
        IEnumerable<UserGroup> GetByRole(Group group);

        IEnumerable<UserGroup> GetByRoleId(Guid groupId);

        IEnumerable<UserGroup> GetByUser(User User);

        IEnumerable<UserGroup> GetByUserId(Guid userId);
    }
}
