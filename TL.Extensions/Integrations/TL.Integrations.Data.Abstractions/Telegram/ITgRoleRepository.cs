using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram
{
    public interface ITgRoleRepository : IRepository
    {
        IEnumerable<TgRole> GetAll();

        TgRole GetById(Guid id);

        TgRole GetByName(string name);
    }
}
