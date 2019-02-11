using System;
using System.Collections.Generic;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Services.TelegramBotProvider
{
    public interface ITelegramBotProviderService
    {
        IEnumerable<Type> GetBotTypes();

        IEnumerable<IBaseBot> GetOnline();

        bool Start(string token, string typeName, out IBaseBot bot, string name = null, bool skipUpdates = false);

        bool Start(string token, Type type, out IBaseBot bot, string name = null, bool skipUpdates = false);

        bool Start(IBaseBot bot);

        bool Stop(string username);

        bool Stop(IBaseBot bot);
    }
}
