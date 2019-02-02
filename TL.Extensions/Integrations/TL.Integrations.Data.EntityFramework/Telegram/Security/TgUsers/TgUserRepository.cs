using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsers
{
    public class TgUserRepository : RepositoryBase<TgUser>, ITgUserRepository
    {
        public void Add(TgUser user)
        {
            dbSet.Add(user);
        }

        public IEnumerable<TgUser> GetAll()
        {
            return dbSet.OrderBy(e => e.Username);
        }

        public IEnumerable<TgUser> GetByAccountId(Guid id)
        {
            return dbSet.Where(e => e.UserId == id);
        }

        public TgUser GetById(Guid id)
        {
            return dbSet.FirstOrDefault(e => e.Id == id);
        }

        public TgUser GetByTgId(int id)
        {
            return dbSet.FirstOrDefault(e => e.TgId == id);
        }

        public void Update(TgUser user)
        {
            dbSet.Update(user);
        }
    }
}
