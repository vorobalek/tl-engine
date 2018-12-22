using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.UsersRoles
{
    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
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
