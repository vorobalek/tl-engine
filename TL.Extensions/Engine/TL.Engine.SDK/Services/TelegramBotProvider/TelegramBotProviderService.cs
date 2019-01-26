using ExtCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Services.TelegramBotProvider
{
    public class TelegramBotProviderService : ITelegramBotProviderService
    {
        ILogger Logger { get; }

        public static List<IBaseBot> OnlineBots { get; } = new List<IBaseBot>();

        public TelegramBotProviderService(ILogger<TelegramBotProviderService> logger)
        {
            Logger = logger;
        }

        public IEnumerable<Type> GetBotTypes()
        {
            return ExtensionManager
                .GetImplementations<IBaseBot>()
                .Where(t => !t.IsAbstract);
        }

        public IEnumerable<IBaseBot> GetOnline() => OnlineBots;

        public async Task StartAsync(IBaseBot bot)
        {
            if (OnlineBots.FirstOrDefault(it => it.Token == bot.Token) == null)
            {
                await bot.StartAsync();
                OnlineBots.Add(bot);
            }
        }

        public async Task StopAsync(IBaseBot bot)
        {
            OnlineBots.RemoveAll(it => it.Token == bot.Token);
            await bot.StopAsync();
        }
    }
}
