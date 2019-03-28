using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Reflection;
using TL.Integrations.SDK.Telegram.Attributes;
using TL.Integrations.SDK.Telegram.Services;

namespace TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram.Index
{
    public class IndexViewModelFactory
    {
        public IndexViewModel Create(ITelegramBotProviderService telegramBotProvider)
        {
            return new IndexViewModel()
            {
                AvailableTypes = telegramBotProvider.GetBotTypes()
                    .Select(it => new SelectListItem((it.GetCustomAttribute(typeof(BotAttribute)) as BotAttribute)?.Name ?? it.Name, it.Name))
                    .OrderBy(it => it.Text),
                Bots = telegramBotProvider.GetOnline()
            };
        }
    }
}
