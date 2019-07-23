using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TL.Integrations.Data.Entities.Telegram.System;
using TL.Integrations.Data.Managers;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.SDK.Telegram.Services;
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

        public TelegramController(ITelegramBotProviderService telegramBotProvider, IServiceProvider serviceProvider, ITgBotManager tgBotManager)
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
            return PartialView("_TelegramBots", new TelegramBotsViewModelFactory().Create(TgBotManager, TelegramBotProvider));
        }

        [HttpPost]
        public IActionResult StartSaved(string id)
        {
            string message;
            if (Guid.TryParse(id, out Guid guid))
            {
                var savedBot = TgBotManager.GetByKey(guid);
                if (savedBot != null)
                {
                    bool f = TelegramBotProvider.DelayedStart(ServiceProvider, savedBot.Token, savedBot.TypeName, out IBaseBot bot, savedBot.NativeName, savedBot.SkipUpdates, savedBot.AutoStart);
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
            string message;
            var bot = TelegramBotProvider.GetOnline().FirstOrDefault(e => e.Username == username);
            if (bot == null)
            {
                message = $"Бот с именем @{username} не был запущен";
            }
            else
            {
                var tgBot = TgBotManager.Get(e => e.Token == bot.Token && e.TypeName == bot.GetType().Name);
                var oldState = tgBot.State;
                tgBot.State = TgBotState.Pause;
                TgBotManager.Update(tgBot);

                bool f = TelegramBotProvider.Stop(username);
                if (f)
                {
                    tgBot.State = TgBotState.Stop;
                    TgBotManager.Update(tgBot);
                    message = $"Бот @{username} остановлен";
                }
                else
                {
                    tgBot.State = oldState;
                    TgBotManager.Update(tgBot);
                    message = $"Не удалось остановить бота @{username}";
                }
            }
            return PartialView("_StatusMessage", message);
        }
    }
}
