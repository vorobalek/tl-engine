using System;
using System.Collections.Generic;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Entities.Telegram.Relationships;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.Abstractions.Telegram.Relationships
{
    public interface ITgConnectionRepository : IEntityRepository<TgConnection>
    {
        void Add(TgBot bot, TgUser user);

        void Add(Guid botId, Guid userId);

        void Delete(TgBot bot, TgUser user);

        void Delete(Guid botId, Guid userId);

        IEnumerable<Guid> GetBots(TgUser user);

        IEnumerable<Guid> GetBots(Guid userId);

        IEnumerable<Guid> GetMembers(TgBot bot);

        IEnumerable<Guid> GetMembers(Guid botId);
    }
}
