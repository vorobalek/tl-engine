using System.Collections.Generic;
using System.Linq;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.Data.Entities.Telegram.System;

namespace TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram.Shared
{
    public class TelegramBotsViewModel
    {
        public IEnumerable<TgBot> SavedBots { get; set; }

        public IEnumerable<IBaseBot> ActiveBots { get; set; }

        public IEnumerable<TgBot> SavedNoActive => SavedBots.Where(sb => !ActiveBots.Select(ab => ab.Token).Contains(sb.Token));
    }
}
