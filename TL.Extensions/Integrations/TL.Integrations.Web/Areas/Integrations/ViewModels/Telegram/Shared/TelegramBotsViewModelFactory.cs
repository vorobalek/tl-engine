using ExtCore.Data.Abstractions;
using System;
using TL.Integrations.Data.Abstractions.Telegram.System;
using TL.Integrations.Data.Managers;
using TL.Integrations.SDK.Telegram.Services;

namespace TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram.Shared
{
    public class TelegramBotsViewModelFactory
    {
        private static TelegramBotsViewModel Model { get; set; }

        private static DateTime LastUpdate { get; set; }

        public TelegramBotsViewModel Create(ITgBotManager tgBotManager, ITelegramBotProviderService telegramBotProvider)
        {
            var savedBots = tgBotManager.GetAll(e => true);
            var activeBots = telegramBotProvider.GetOnline();

            Model = new TelegramBotsViewModel()
            {
                SavedBots = savedBots,
                ActiveBots = activeBots,
            };

            LastUpdate = DateTime.Now.ToUniversalTime();

            return Model;
        }
    }
}
