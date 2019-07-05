using Microsoft.Extensions.Logging;
using System.Linq;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Extensions;
using TL.Integrations.Data.Entities.Telegram.System;
using TL.Integrations.Data.Managers;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.SDK.Telegram.Services;

namespace TL.Integrations.Telegram.Services
{
    public class AutoStartBotServiceStartupAction : IStartupAction
    {
        ITgBotManager TgBotManager { get; }

        ITelegramBotProviderService TelegramBotProvider { get; }

        ILogger Logger { get; }

        public bool IsBlocker => false;

        public int Priority => 10000;

        public string Description => "Автозапуск ботов Telegram";

        public AutoStartBotServiceStartupAction(ITelegramBotProviderService telegramBotProvider, ITgBotManager tgBotManager, ILogger<AutoStartBotServiceStartupAction> logger)
        {
            TgBotManager = tgBotManager;
            TelegramBotProvider = telegramBotProvider;
            Logger = logger;
        }

        public IStartupActionResult Invoke()
        {
            var tgBots = TgBotManager.GetAll(e => e.AutoStart || e.State == TgBotState.Restart || e.State == TgBotState.Start || e.State == TgBotState.Run).ToArray();

            for (int i = 0; i < tgBots.Length; ++i)
            {
                var tgBot = tgBots[i];
                Logger.TLogWarning($"Попытка автоматического запуска бота @{tgBot.Username} на {tgBot.TypeName}");

                tgBot.State = TgBotState.Start;
                TgBotManager.Update(tgBot);

                bool f = TelegramBotProvider.Start(tgBot.Token, tgBot.TypeName, out IBaseBot bot, tgBot.NativeName, tgBot.SkipUpdates);
                if (f)
                {
                    Logger.TLogWarning($"Успешный автоматический запуска бота @{tgBot.Username} на {tgBot.TypeName}");

                    tgBot.State = TgBotState.Run;
                }
                else
                {
                    Logger.TLogWarning($"Отказ запуска бота @{tgBot.Username} на {tgBot.TypeName}");

                    tgBot.State = TgBotState.Stop;
                }
                TgBotManager.Update(tgBot);
            }

            return StartupActionResult.Good(description: Description);
        }
    }
}
