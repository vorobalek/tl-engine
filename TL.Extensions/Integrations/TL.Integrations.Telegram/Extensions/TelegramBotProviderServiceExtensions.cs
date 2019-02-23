using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Services.TelegramBotProvider;
using TL.Integrations.Data.Entities.Telegram.System;
using TL.Integrations.Data.Managers;

namespace TL.Integrations.Telegram.Extensions
{
    public static class TelegramBotProviderServiceExtensions
    {
        public static bool DelayedStart(this ITelegramBotProviderService telegramBotProvider, IServiceProvider serviceProvider, string token, string typeName, out IBaseBot bot, string nativeName = null, bool skipUpdates = true, bool autoStart = true)
        {
            var tgBotManager = serviceProvider.GetService<ITgBotManager>();

            var tgBot = tgBotManager.Get(e => e.Token == token && e.TypeName == typeName);

            bool isNewBot = false;
            if (tgBot == null)
            {
                isNewBot = true;
                tgBot = tgBotManager.Create(new TgBot()
                {
                    Token = token,
                    TypeName = typeName,
                });
            }

            tgBot.NativeName = nativeName;
            tgBot.SkipUpdates = skipUpdates;
            tgBot.AutoStart = autoStart;
            tgBot.State = TgBotState.Start;
            tgBotManager.Update(tgBot);

            bool success = telegramBotProvider.Start(token, typeName, out bot, nativeName, skipUpdates);

            if (success)
            {
                tgBot.State = TgBotState.Run;
                tgBot.Username = bot.Username;
                tgBot.LastStartDate = DateTime.Now.ToUniversalTime();

                tgBotManager.Update(tgBot);
                return true;
            }
            else
            {
                tgBot.State = TgBotState.Stop;
                tgBotManager.Update(tgBot);

                if (isNewBot)
                {
                    tgBotManager.Delete(tgBot);
                }
            }
            return false;
        }
    }
}
