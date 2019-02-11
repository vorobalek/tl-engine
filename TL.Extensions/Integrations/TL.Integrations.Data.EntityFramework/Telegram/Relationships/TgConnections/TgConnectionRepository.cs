using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Integrations.Data.Abstractions.Telegram.Relationships;
using TL.Integrations.Data.Entities.Telegram.Relationships;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.EntityFramework.Telegram.Relationships.TgConnections
{
    public class TgConnectionRepository : RepositoryBase<TgConnection>, ITgConnectionRepository
    {
        public void Add(TgBot bot, TgUser user)
        {
            Add(bot.Id, user.Id);
        }

        public void Add(Guid botId, Guid userId)
        {
            dbSet.Add(new TgConnection() { BotId = botId, UserId = userId });
        }

        public IEnumerable<Guid> GetBots(TgUser user)
        {
            return GetBots(user.Id);
        }

        public IEnumerable<Guid> GetBots(Guid userId)
        {
            return dbSet.Where(e => e.UserId == userId).Select(e => e.BotId);
        }

        public void Delete(TgBot bot, TgUser user)
        {
            Delete(bot.Id, user.Id);
        }

        public void Delete(Guid botId, Guid userId)
        {
            dbSet.Remove(new TgConnection() { BotId = botId, UserId = userId });
        }

        public IEnumerable<Guid> GetMembers(TgBot bot)
        {
            return GetMembers(bot.Id);
        }

        public IEnumerable<Guid> GetMembers(Guid botId)
        {
            return dbSet.Where(e => e.BotId == botId).Select(e => e.UserId);
        }
    }
}
