using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Services.TelegramBotProvider;
using TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram;

namespace TL.Integrations.Web.Areas.Integrations.Controllers
{
    public class TelegramController : __IntegrationsController__
    {
        ITelegramBotProviderService TelegramBotProvider { get; }

        IServiceProvider ServiceProvider { get; }

        public TelegramController(IStorage storage, ITelegramBotProviderService telegramBotProvider, IServiceProvider serviceProvider) : base(storage)
        {
            TelegramBotProvider = telegramBotProvider;
            ServiceProvider = serviceProvider;
        }

        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create(TelegramBotProvider));
        }

        [HttpPost]
        public IActionResult Update()
        {
            return PartialView("_OnlineBots", new IndexViewModelFactory().Create(TelegramBotProvider).Bots);
        }

        [HttpPost]
        public async Task<IActionResult> Start(IndexViewModel model)
        {
            string message;
            if (ModelState.IsValid)
            {
                var parts = model.Token.Split(':');
                if (parts.Length > 1 && int.TryParse(parts[0], out int id))
                {
                    bool f = await TelegramBotProvider.StartAsync(model.BotType, model.Token, null, model.QuietStartup);
                    if (f)
                    {
                        message = "Бот запущен";
                    }
                    else
                    {
                        message = "Не удалось запустить бота";
                    }
                }
                else
                {
                    message = "Токен указан неверно! Токен должен выглядеть как-то так: \"123456789:AAG94pkt5-jUyHJT2TukjNPOkW_zkATWx70\"";
                }
            }
            else
            {
                message = "Одно или несколько полей были заполнены неверно";
            }
            return PartialView("_StatusMessage", message);
        }

        [HttpPost]
        public async Task<IActionResult> Kill(string username)
        {
            bool f = await TelegramBotProvider.StopAsync(username);
            string message;
            if (f)
            {
                message = "Бот остановлен";
            }
            else
            {
                message = "Не удалось остановить бота";
            }
            return PartialView("_StatusMessage", message);
        }
    }
}
