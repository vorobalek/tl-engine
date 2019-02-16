using System;
using System.Linq;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgRoles
{
    public class TgRoleRepository : EntityComparableStoredRepository<TgRole, Guid>, ITgRoleRepository
    {
        public TgRole GetByName(string name)
        {
            return Load(dbSet.SingleOrDefault(e => e.Name == name));
        }
    }
}
