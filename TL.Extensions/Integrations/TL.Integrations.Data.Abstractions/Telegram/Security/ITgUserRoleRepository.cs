using System;
using System.Collections.Generic;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram.Security
{
    public interface ITgUserRoleRepository : IEntityRepository<TgUserRole>
    {
        IEnumerable<TgUserRole> GetByRole(TgRole role);

        IEnumerable<TgUserRole> GetByRoleId(Guid roleId);

        IEnumerable<TgUserRole> GetByUser(TgUser user);

        IEnumerable<TgUserRole> GetByUserId(Guid userId);
    }
}
