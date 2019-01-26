using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.TelegramBots.Web.Areas.TelegramBots.ViewModels.Home
{
    public class IndexViewModel
    {
        public string Token { get; set; }

        public string BotType { get; set; }

        public SelectList AvailableTypes { get; set; }

        public IEnumerable<IBaseBot> Bots { get; set; }
    }
}
