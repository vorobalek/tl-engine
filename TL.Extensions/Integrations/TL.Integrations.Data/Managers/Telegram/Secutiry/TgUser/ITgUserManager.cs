using System;
using TL.Engine.SDK.Managers;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Managers
{
    public interface ITgUserManager : IEntityComparableManager<TgUser, Guid>
    {
        TgUser Get(int id);

        TgUser Create(int id, string username = null, string firstname = null, string lastname = null);

        TgUser GetOrCreate(int id, string username = null, string firstname = null, string lastname = null);
    }
}
