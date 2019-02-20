using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Services.TelegramBotProvider;
using TL.Integrations.Data.Entities.Telegram.System;
using TL.Integrations.Data.Managers;

namespace TL.Integrations.Telegram.Services
{
    public class AutoStartBotServiceStartupFilter : IStartupFilter
    {
        ITgBotManager TgBotManager { get; }

        ITelegramBotProviderService TelegramBotProvider { get; }

        ILogger Logger { get; }

        public AutoStartBotServiceStartupFilter(ITelegramBotProviderService telegramBotProvider, ITgBotManager tgBotManager, ILoggerFactory loggerFactory)
        {
            TgBotManager = tgBotManager;
            TelegramBotProvider = telegramBotProvider;
            Logger = loggerFactory.CreateLogger(GetType());
        }

        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            try
            {
                var tgBots = TgBotManager.GetAll(e => e.AutoStart || e.State == TgBotState.Restart || e.State == TgBotState.Start || e.State == TgBotState.Run);

                foreach (var tgBot in tgBots)
                {
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
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить процесс автоматического запуска ботов\r\n{ex}");
            }
            return next;
        }
    }
}
