using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Services.TelegramBotProvider;
using TL.Integrations.Data.Managers;
using TL.Integrations.Telegram.Extensions;
using TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram.Index;
using TL.Integrations.Web.Areas.Integrations.ViewModels.Telegram.Shared;

namespace TL.Integrations.Web.Areas.Integrations.Controllers
{
    public class TelegramController : __IntegrationsController__
    {
        ITelegramBotProviderService TelegramBotProvider { get; }

        IServiceProvider ServiceProvider { get; }

        ITgBotManager TgBotManager { get; }

        public TelegramController(IStorage storage, ITelegramBotProviderService telegramBotProvider, IServiceProvider serviceProvider, ITgBotManager tgBotManager) : base(storage)
        {
            TelegramBotProvider = telegramBotProvider;
            ServiceProvider = serviceProvider;
            TgBotManager = tgBotManager;
        }

        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create(TelegramBotProvider));
        }

        [HttpPost]
        public IActionResult Update()
        {
            return PartialView("_TelegramBots", new TelegramBotsViewModelFactory().Create(Storage, TelegramBotProvider));
        }

        [HttpPost]
        public IActionResult StartSaved(string id)
        {
            string message;
            if (Guid.TryParse(id, out Guid guid))
            {
                var savedBot = TgBotManager.Get(guid);
                if (savedBot != null)
                {
                    bool f = TelegramBotProvider.DelayedStart(ServiceProvider, savedBot.Token, savedBot.TypeName, out IBaseBot bot, savedBot.Username, savedBot.SkipUpdates, savedBot.AutoStart);
                    if (f)
                    {
                        message = $"Бот @{bot.Username} запущен";
                    }
                    else
                    {
                        message = $"Не удалось запустить бота @{savedBot.Username}";
                    }
                }
                else
                {
                    message = "Не удалось обнаружить бота";
                }
            }
            else
            {
                message = "Не удалось разобрать идентефикатор бота";
            }
            return PartialView("_StatusMessage", message);
        }

        [HttpPost]
        public IActionResult Start(IndexViewModel model)
        {
            string message;
            if (ModelState.IsValid)
            {
                var parts = model.Token.Split(':');
                if (parts.Length > 1 && int.TryParse(parts[0], out int id))
                {
                    bool f = TelegramBotProvider.DelayedStart(ServiceProvider, model.Token, model.BotType, out IBaseBot bot, null, model.SkipUpdates, model.AutoStartup);
                    if (f)
                    {
                        message = $"Бот @{bot.Username} запущен";
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
        public IActionResult Kill(string username)
        {
            bool f = TelegramBotProvider.Stop(username);
            string message;
            if (f)
            {
                message = $"Бот @{username} остановлен";
            }
            else
            {
                message = $"Не удалось остановить бота @{username}";
            }
            return PartialView("_StatusMessage", message);
        }
    }
}
