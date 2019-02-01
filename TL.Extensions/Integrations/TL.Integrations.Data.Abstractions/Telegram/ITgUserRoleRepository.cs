using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram
{
    public interface ITgUserRoleRepository : IRepository
    {
        IEnumerable<TgUserRole> GetByRole(TgRole role);

        IEnumerable<TgUserRole> GetByRoleId(Guid roleId);

        IEnumerable<TgUserRole> GetByUser(TgUser user);

        IEnumerable<TgUserRole> GetByUserId(Guid userId);
    }
}
