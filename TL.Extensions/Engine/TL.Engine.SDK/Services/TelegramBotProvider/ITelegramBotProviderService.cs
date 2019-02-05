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

        Task<bool> StartAsync(string botTypeName, string token, string name = null, bool skipUpdates = false);

        Task<bool> StartAsync(Type botType, string token, string name = null, bool skipUpdates = false);

        Task<bool> StartAsync(IBaseBot bot);

        Task<bool> StopAsync(string username);

        Task<bool> StopAsync(IBaseBot bot);
    }
}
