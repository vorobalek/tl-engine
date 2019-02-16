using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Services.TelegramBotProvider;
using TL.Integrations.Data.Managers;

namespace TL.Integrations.Telegram.Extensions
{
    public static class TelegramBotProviderServiceExtensions
    {
        public static bool DelayedStart(this ITelegramBotProviderService telegramBotProvider, IServiceProvider serviceProvider, string token, string typeName, out IBaseBot bot, string nativeName = null, bool skipUpdates = true, bool autoStart = true)
        {
            var tgBotManager = serviceProvider.GetService<ITgBotManager>();

            var tgBot = tgBotManager.Get(token, typeName);
            bool isNewBot = false;
            if (tgBot == null)
            {
                isNewBot = true;
                tgBot = tgBotManager.Create(token, typeName);
            }

            bool success = telegramBotProvider.Start(token, typeName, out bot, nativeName, skipUpdates);
            if (success)
            {
                tgBotManager.UpdateOrCreate(token, typeName, bot.Username, nativeName, skipUpdates, autoStart, DateTime.Now.ToUniversalTime());
                return true;
            }
            else
            {
                if (isNewBot)
                {
                    tgBotManager.Remove(tgBot);
                }
            }
            return false;
        }
    }
}
