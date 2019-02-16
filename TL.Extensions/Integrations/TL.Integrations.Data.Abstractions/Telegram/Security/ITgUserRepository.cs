using System;
using System.Collections.Generic;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram.Security
{
    public interface ITgUserRepository : IEntityComparableStoredRepository<TgUser, Guid>
    {
        IEnumerable<TgUser> GetByAccountId(Guid id);

        TgUser GetByTgId(int id);
    }
}
