using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Abstractions.Telegram.System;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.EntityFramework.Telegram.System.TgBots
{
    public class TgBotRepository : EntityComparableStoredRepository<TgBot, Guid>, ITgBotRepository
    {
        public TgBot GetByTokenAndType(string token, string type)
        {
            return Load(dbSet.FirstOrDefault(it => it.Token == token && it.TypeName == type));
        }

        public IEnumerable<TgBot> GetByUsername(string username)
        {
            return dbSet.Where(e => e.Username == username).Select(e => Load(dbSet.FirstOrDefault(ee => ee.Id == e.Id)));
        }
    }
}
