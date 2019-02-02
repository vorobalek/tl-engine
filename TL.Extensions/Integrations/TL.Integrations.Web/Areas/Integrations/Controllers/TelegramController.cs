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
            var ret = new IndexViewModelFactory().Create(TelegramBotProvider);
            var parts = model.Token.Split(':');
            if (parts.Length > 0 && int.TryParse(parts[0], out int id))
            {
                var bot = ExtensionManager.GetImplementations<Telegram.Bots.BaseBot>().Where(t => !t.IsAbstract).FirstOrDefault(t => t.Name == model.BotType);
                if (bot != null)
                {
                    await TelegramBotProvider.StartAsync(Activator.CreateInstance(bot, ServiceProvider, model.Token, null, model.QuietStartup) as Telegram.Bots.BaseBot);
                }
            }
            else
            {
                ret.StatusMessage = "Токен указан неверно! Токен должен выглядеть как-то так: \"123456789:AAG94pkt5-jUyHJT2TukjNPOkW_zkATWx70\"";
            }
            return PartialView("_OnlineBots", ret.Bots);
        }

        [HttpPost]
        public async Task<IActionResult> Kill(string username)
        {
            var bot = TelegramBotProvider.GetOnline().FirstOrDefault(it => it.Username == username);
            if (bot != null)
            {
                await TelegramBotProvider.StopAsync(bot);
            }
            return PartialView("_OnlineBots", new IndexViewModelFactory().Create(TelegramBotProvider).Bots);
        }
    }
}
