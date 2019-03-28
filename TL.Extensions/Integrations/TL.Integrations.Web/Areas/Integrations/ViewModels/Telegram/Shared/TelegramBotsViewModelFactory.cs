using ExtCore.Data.Abstractions;
using System;
using TL.Integrations.Data.Abstractions.Telegram.System;
using TL.Integrations.SDK.Telegram.Services;

namespace TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram.Shared
{
    public class TelegramBotsViewModelFactory
    {
        private static TelegramBotsViewModel Model { get; set; }

        private static DateTime LastUpdate { get; set; }

        public TelegramBotsViewModel Create(IStorage storage, ITelegramBotProviderService telegramBotProvider)
        {
            var savedBots = storage.GetRepository<ITgBotRepository>().GetAll();
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
