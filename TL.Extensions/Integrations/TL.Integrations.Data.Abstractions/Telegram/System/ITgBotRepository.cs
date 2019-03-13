using System;
using System.Collections.Generic;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.Abstractions.Telegram.System
{
    public interface ITgBotRepository : IEntityComparableStoredRepository<TgBot, Guid>
    {
        IEnumerable<TgBot> GetByUsername(string username);

        TgBot GetByTokenAndType(string token, string type);
    }
}
