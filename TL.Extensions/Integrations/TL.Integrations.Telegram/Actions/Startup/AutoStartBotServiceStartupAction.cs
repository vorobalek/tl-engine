using Microsoft.Extensions.Logging;
using System.Linq;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Services;
using TL.Integrations.Data.Entities.Telegram.System;
using TL.Integrations.Data.Managers;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.SDK.Telegram.Services;

namespace TL.Integrations.Telegram.Actions
{
    public class AutoStartBotServiceStartupAction : IStartupAction
    {
        ITgBotManager TgBotManager { get; }

        ITelegramBotProviderService TelegramBotProvider { get; }

        ILogger Logger { get; }

        IStartupService Service { get; }

        public int Priority => 10000;

        public string Description => "Автозапуск ботов Telegram";

        public AutoStartBotServiceStartupAction(ITelegramBotProviderService telegramBotProvider, ITgBotManager tgBotManager, ILogger<AutoStartBotServiceStartupAction> logger, IStartupService service)
        {
            TgBotManager = tgBotManager;
            TelegramBotProvider = telegramBotProvider;
            Logger = logger;
            Service = service;
        }

        public IStartupActionResult Invoke()
        {
            bool ok = true;
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
                    Service.InvokeCallback($"Успешный автоматический запуска бота @{tgBot.Username} на {tgBot.TypeName} ({i + 1} из {tgBots.Length})", (i + 1) / (double)tgBots.Length * 100);

                    tgBot.State = TgBotState.Run;
                }
                else
                {
                    Logger.TLogWarning($"Отказ запуска бота @{tgBot.Username} на {tgBot.TypeName}");
                    Service.InvokeCallback($"Отказ запуска бота @{tgBot.Username} на {tgBot.TypeName} ({i + 1} из {tgBots.Length})", (i + 1) / (double)tgBots.Length * 100);
                    ok = false;
                    tgBot.State = TgBotState.Stop;
                }
                TgBotManager.Update(tgBot);
            }

            return ok ? StartupActionResult.Good(description: Description) : StartupActionResult.Bad("Fail", description: Description);
        }
    }
}
