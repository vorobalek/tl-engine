using ExtCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.SDK.Services.TelegramBotProvider
{
    public class TelegramBotProviderService : ITelegramBotProviderService
    {
        ILogger Logger { get; }

        IServiceProvider ServiceProvider { get; }

        private List<IBaseBot> OnlineBots { get; } = new List<IBaseBot>();

        private List<string> CandidateBots { get; } = new List<string>();

        public TelegramBotProviderService(ILogger<TelegramBotProviderService> logger, IServiceProvider serviceProvider)
        {
            Logger = logger;
            ServiceProvider = serviceProvider;
        }

        public IEnumerable<Type> GetBotTypes()
        {
            return ExtensionManager
                .GetImplementations<IBaseBot>()
                .Where(t => !t.IsAbstract);
        }

        public IEnumerable<IBaseBot> GetOnline() => OnlineBots;

        public Task<bool> StartAsync(string botTypeName, string token, string name = null, bool skipUpdates = false)
        {
            var botType = ExtensionManager.GetImplementations<IBaseBot>().Where(t => !t.IsAbstract).FirstOrDefault(t => t.Name == botTypeName);
            return StartAsync(botType, token, name, skipUpdates);
        }

        public Task<bool> StartAsync(Type botType, string token, string name = null, bool skipUpdates = false)
        {
            if (botType == null)
            {
                throw new ArgumentNullException(nameof(botType));
            }

            var bot = Activator.CreateInstance(botType, ServiceProvider, token, name, skipUpdates) as IBaseBot;
            return StartAsync(bot);
        }

        public async Task<bool> StartAsync(IBaseBot bot)
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (OnlineBots.FirstOrDefault(it => it.Token == bot.Token) == null && !CandidateBots.Contains(bot.Token))
            {
                CandidateBots.Add(bot.Token);
                await bot.StartAsync();
                OnlineBots.Add(bot);
                CandidateBots.RemoveAll(it => it == bot.Token);
                return true;
            }
            else
            {
                Logger.TLogError($"Отказано в запуске бота @{bot.Username} - бот с этим токеном уже запущен!");
                return false;
            }
        }

        public Task<bool> StopAsync(string username)
        {
            var bot = OnlineBots.FirstOrDefault(b => b.Username == username);
            return StopAsync(bot);
        }

        public async Task<bool> StopAsync(IBaseBot bot)
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (!CandidateBots.Contains(bot.Token))
            {
                CandidateBots.Add(bot.Token);
                OnlineBots.RemoveAll(it => it.Token == bot.Token);
                await bot.StopAsync();
                CandidateBots.RemoveAll(it => it == bot.Token);
                return true;
            }
            else
            {
                Logger.TLogError($"Отказано в остановке бота @{bot.Username} - бот с этим токеном уже останавливается!");
                return false;
            }
        }
    }
}
