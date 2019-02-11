using System;
using TL.Integrations.Data.Entities.Telegram.Security;

namespace TL.Integrations.Data.Managers
{
    public interface ITgUserManager
    {
        TgUser Get(int id);

        TgUser Get(Guid id);

        TgUser Create(int id, string username = null, string firstname = null, string lastname = null);

        TgUser GetOrCreate(int id, string username = null, string firstname = null, string lastname = null);
    }
}
