using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.Data.EntityFramework.Security.UsersRoles
{
    public class UserRoleRepository : EntityComparableRepository<UserRole, (Guid, Guid)>, IUserRoleRepository
    {
        public IEnumerable<UserRole> GetByUser(User user)
        {
            return GetByUserId(user.Id);
        }

        public IEnumerable<UserRole> GetByUserId(Guid userId)
        {
            return dbSet.Where(e => e.UserId == userId).ToList();
        }

        public IEnumerable<UserRole> GetByRole(Role role)
        {
            return GetByRoleId(role.Id);
        }

        public IEnumerable<UserRole> GetByRoleId(Guid roleId)
        {
            return dbSet.Where(e => e.RoleId == roleId).ToList();
        }
    }
}
