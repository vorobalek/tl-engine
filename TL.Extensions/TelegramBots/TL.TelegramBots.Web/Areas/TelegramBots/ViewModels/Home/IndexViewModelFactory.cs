using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TL.Engine.SDK.Services.TelegramBotProvider;

namespace TL.TelegramBots.Web.Areas.TelegramBots.ViewModels.Home
{
    public class IndexViewModelFactory
    {
        public IndexViewModel Create(ITelegramBotProviderService telegramBotProvider)
        {
            return new IndexViewModel()
            {
                AvailableTypes = new SelectList(telegramBotProvider.GetBotTypes().OrderBy(t => t.Name).Select(it => it.Name)),
                Bots = telegramBotProvider.GetOnline()
            };
        }
    }
}
