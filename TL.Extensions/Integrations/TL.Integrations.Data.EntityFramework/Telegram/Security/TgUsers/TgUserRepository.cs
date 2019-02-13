using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsers
{
    public class TgUserRepository : EntityRepository<TgUser>, ITgUserRepository
    {
        public void Add(TgUser user)
        {
            dbSet.Add(user);
        }

        public IEnumerable<TgUser> GetAll()
        {
            return dbSet.OrderBy(e => e.Username).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public IEnumerable<TgUser> GetByAccountId(Guid id)
        {
            return dbSet.Where(e => e.UserId == id).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public TgUser GetById(Guid id)
        {
            return Load(dbSet.SingleOrDefault(e => e.Id == id));
        }

        public TgUser GetByTgId(int id)
        {
            return Load(dbSet.SingleOrDefault(e => e.TgId == id));
        }

        public void Update(TgUser user)
        {
            dbSet.Update(user);
        }
    }
}
