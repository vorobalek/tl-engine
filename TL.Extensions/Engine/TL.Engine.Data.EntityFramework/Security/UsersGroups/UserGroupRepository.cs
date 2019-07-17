using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.Security.UsersGroups
{
    public class UserGroupRepository : EntityComparableRepository<UserGroup, (Guid, Guid)>, IUserGroupRepository
    {
        public IEnumerable<UserGroup> GetByUser(User user)
        {
            return GetByUserId(user.Id);
        }

        public IEnumerable<UserGroup> GetByUserId(Guid userId)
        {
            return dbSet.Where(e => e.UserId == userId).ToList();
        }

        public IEnumerable<UserGroup> GetByRole(Group group)
        {
            return GetByRoleId(group.Id);
        }

        public IEnumerable<UserGroup> GetByRoleId(Guid groupId)
        {
            return dbSet.Where(e => e.GroupId == groupId).ToList();
        }
    }
}
