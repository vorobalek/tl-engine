using ExtCore.Data.Abstractions;
using System;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Abstractions.Telegram.System;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.Extensions
{
    public static class GuidExtensions
    {
        public static TgBot GetTgBot(this Guid guid, IStorage storage)
        {
            var tgBot = storage.GetRepository<ITgBotRepository>().GetById(guid);
            return tgBot;
        }

        public static TgUser GetTgUser(this Guid guid, IStorage storage)
        {
            var tgUser = storage.GetRepository<ITgUserRepository>().GetById(guid);
            return tgUser;
        }
    }
}
