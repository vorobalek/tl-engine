using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Abstractions.Telegram.System;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.EntityFramework.Telegram.System.TgBots
{
    public class TgBotRepository : EntityRepository<TgBot>, ITgBotRepository
    {
        public void Add(TgBot bot)
        {
            dbSet.Add(bot);
        }

        public void Update(TgBot bot)
        {
            bot.ModifiedDate = DateTime.Now.ToUniversalTime();
            dbSet.Update(bot);
        }

        public void Remove(TgBot bot)
        {
            dbSet.Remove(bot);
        }

        public void Remove(Guid guid)
        {
            var candidate = dbSet.FirstOrDefault(e => e.Id == guid);
            if (candidate != null)
            {
                dbSet.Remove(candidate);
            }
        }

        public IEnumerable<TgBot> GetAll()
        {
            return dbSet.OrderBy(e => e.Username).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }

        public TgBot GetById(Guid id)
        {
            return Load(dbSet.SingleOrDefault(e => e.Id == id));
        }

        public TgBot GetByTokenAndType(string token, string type)
        {
            return Load(dbSet.SingleOrDefault(it => it.Token == token && it.TypeName == type));
        }

        public IEnumerable<TgBot> GetByUsername(string username)
        {
            return dbSet.Where(e => e.Username == username).Select(e => Load(dbSet.Single(ee => ee.Id == e.Id)));
        }
    }
}
