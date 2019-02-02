using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgBots
{
    public class TgBotRepository : RepositoryBase<TgBot>, ITgBotRepository
    {
        public void Add(TgBot bot)
        {
            dbSet.Add(bot);
        }

        public IEnumerable<TgBot> GetAll()
        {
            return dbSet.OrderBy(e => e.Username);
        }

        public TgBot GetById(Guid id)
        {
            return dbSet.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<TgBot> GetByUsername(string username)
        {
            return dbSet.Where(e => e.Username == username);
        }

        public void Update(TgBot bot)
        {
            dbSet.Update(bot);
        }
    }
}
