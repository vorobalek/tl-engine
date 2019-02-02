using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram
{
    public class IndexViewModel
    {
        public string StatusMessage { get; set; }

        public string Token { get; set; }

        public string BotType { get; set; }

        public bool QuietStartup { get; set; }

        public SelectList AvailableTypes { get; set; }

        public IEnumerable<IBaseBot> Bots { get; set; }
    }
}
