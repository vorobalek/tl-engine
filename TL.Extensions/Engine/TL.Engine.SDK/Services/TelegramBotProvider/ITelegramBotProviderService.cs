using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Services.TelegramBotProvider
{
    public interface ITelegramBotProviderService
    {
        IEnumerable<Type> GetBotTypes();

        IEnumerable<IBaseBot> GetOnline();

        Task StartAsync(IBaseBot bot);

        Task StopAsync(IBaseBot bot);
    }
}
