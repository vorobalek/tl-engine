using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsers
{
    public class TgUserRepository : EntityComparableStoredRepository<TgUser, Guid>, ITgUserRepository
    {
        public IEnumerable<TgUser> GetByAccountId(Guid id)
        {
            return dbSet.Where(e => e.UserId == id).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public TgUser GetByTgId(int id)
        {
            return Load(dbSet.SingleOrDefault(e => e.TgId == id));
        }
    }
}
