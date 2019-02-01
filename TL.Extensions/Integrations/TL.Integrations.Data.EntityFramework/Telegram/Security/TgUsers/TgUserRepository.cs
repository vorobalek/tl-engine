using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Integrations.Data.Abstractions.Telegram;
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
            return dbSet.OrderBy(e => e.RegistrationDate);
        }

        public IEnumerable<TgUser> GetAllReferrals(TgUser user)
        {
            return dbSet.Where(e => e.ReferrerId == user.Id);
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
