using System;
using System.Collections.Generic;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram.Security
{
    public interface ITgUserRepository : IEntityRepository<TgUser>
    {
        IEnumerable<TgUser> GetByAccountId(Guid id);

        TgUser GetById(Guid id);

        TgUser GetByTgId(int id);

        void Add(TgUser user);

        void Update(TgUser user);

        IEnumerable<TgUser> GetAll();
    }
}
