using ExtCore.Data.Abstractions;
using System;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Extensions
{
    public static class Int32Extensions
    {
        public static TgUser GetTgUser(this Int32 id, IStorage storage)
        {
            var tgUser = storage.GetRepository<ITgUserRepository>().GetByTgId(id);
            return tgUser;
        }
    }
}
