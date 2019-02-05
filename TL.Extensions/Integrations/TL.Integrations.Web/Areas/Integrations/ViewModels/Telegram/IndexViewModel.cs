using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "Для запуска бота необходим токен")]
        public string Token { get; set; }

        [Required(ErrorMessage = "Необходимо выбрать логику поведения")]
        public string BotType { get; set; }

        public bool QuietStartup { get; set; }

        public SelectList AvailableTypes { get; set; }

        public IEnumerable<IBaseBot> Bots { get; set; }
    }
}
