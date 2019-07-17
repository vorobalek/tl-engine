using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsersRoles
{
    public class TgUserRoleRepository : EntityComparableRepository<TgUserRole, (Guid, Guid)>, ITgUserRoleRepository
    {
        public IEnumerable<TgUserRole> GetByRole(TgRole role)
        {
            return GetByRoleId(role.Id);
        }

        public IEnumerable<TgUserRole> GetByRoleId(Guid roleId)
        {
            return dbSet.Where(e => e.RoleId == roleId).ToList();
        }

        public IEnumerable<TgUserRole> GetByUser(TgUser user)
        {
            return GetByUserId(user.Id);
        }

        public IEnumerable<TgUserRole> GetByUserId(Guid userId)
        {
            return dbSet.Where(e => e.UserId == userId).ToList();
        }
    }
}
