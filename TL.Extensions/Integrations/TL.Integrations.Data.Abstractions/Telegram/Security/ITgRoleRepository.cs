using System;
using System.Collections.Generic;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram.Security
{
    public interface ITgRoleRepository : IEntityRepository<TgRole>
    {
        IEnumerable<TgRole> GetAll();

        TgRole GetById(Guid id);

        TgRole GetByName(string name);
    }
}
