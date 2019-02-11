using System;
using TL.Engine.SDK.Managers;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Data.Managers
{
    public interface ITgBotManager : IEntityManager<TgBot>
    {
        TgBot Get(Guid id);

        TgBot Get(string token, string typename);

        TgBot Create(string token, string typename, string username = null, string nativename = null, bool skip_updates = true, bool auto_start = false);

        TgBot GetOrCreate(string token, string typename, string username = null, string nativename = null, bool skip_updates = true, bool auto_start = false);

        TgBot UpdateOrCreate(string token, string typename, string username = null, string nativename = null, bool skip_updates = true, bool auto_start = false, DateTime? lastStartupDate = null);

        void Remove(Guid id);
    }
}
