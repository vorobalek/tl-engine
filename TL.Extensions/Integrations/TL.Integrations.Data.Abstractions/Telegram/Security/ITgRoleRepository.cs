using System;
using TL.Engine.SDK.Repositories;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Abstractions.Telegram.Security
{
    public interface ITgRoleRepository : IEntityComparableStoredRepository<TgRole, Guid>
    {
        TgRole GetByName(string name);
    }
}
