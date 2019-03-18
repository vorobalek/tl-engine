using ExtCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Bots;

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

        public bool Start(string token, string typeName, out IBaseBot bot, string name = null, bool skipUpdates = false)
        {
            var botType = ExtensionManager.GetImplementations<IBaseBot>().Where(t => !t.IsAbstract).FirstOrDefault(t => t.Name == typeName);
            return Start(token, botType, out bot, name, skipUpdates);
        }

        public bool Start(string token, Type type, out IBaseBot bot, string name = null, bool skipUpdates = false)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            bot = Activator.CreateInstance(type, ServiceProvider, token, name, skipUpdates) as IBaseBot;
            return Start(bot);
        }

        public bool Start(IBaseBot bot)
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (OnlineBots.FirstOrDefault(it => it.Token == bot.Token) == null && !CandidateBots.Contains(bot.Token))
            {
                CandidateBots.Add(bot.Token);
                var f = bot.StartAsync().GetAwaiter().GetResult();
                if (f)
                {
                    OnlineBots.Add(bot);
                }
                CandidateBots.RemoveAll(it => it == bot.Token);
                return f;
            }
            else
            {
                Logger.TLogError($"Отказано в запуске бота @{bot.Username} - бот с этим токеном уже запущен!");
                return false;
            }
        }

        public bool Stop(string username)
        {
            var bot = OnlineBots.FirstOrDefault(b => b.Username == username);
            return Stop(bot);
        }

        public bool Stop(IBaseBot bot)
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (!CandidateBots.Contains(bot.Token))
            {
                CandidateBots.Add(bot.Token);
                var f = bot.StopAsync().GetAwaiter().GetResult();
                if (f)
                {
                    OnlineBots.RemoveAll(it => it.Token == bot.Token);
                }
                CandidateBots.RemoveAll(it => it == bot.Token);
                return f;
            }
            else
            {
                Logger.TLogError($"Отказано в остановке бота @{bot.Username} - бот с этим токеном уже останавливается!");
                return false;
            }
        }
    }
}
