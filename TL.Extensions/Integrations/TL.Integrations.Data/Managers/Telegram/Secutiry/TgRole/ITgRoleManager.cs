using System;
using TL.Engine.SDK.Managers;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Managers
{
    public interface ITgRoleManager : IEntityComparableStoredManager<TgRole, Guid>
    {
    }
}
