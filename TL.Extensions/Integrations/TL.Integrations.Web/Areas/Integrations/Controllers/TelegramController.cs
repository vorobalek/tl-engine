using ExtCore.Data.Abstractions;
using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        ILoggerFactory LoggerFactory { get; }

        public TelegramController(IStorage storage, ITelegramBotProviderService telegramBotProvider, ILoggerFactory loggerFactory) : base(storage)
        {
            TelegramBotProvider = telegramBotProvider;
            LoggerFactory = loggerFactory;
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
            var bot = ExtensionManager.GetImplementations<IBaseBot>().Where(t => !t.IsAbstract).FirstOrDefault(t => t.Name == model.BotType);
            if (bot != null)
            {
                await TelegramBotProvider.StartAsync(Activator.CreateInstance(bot, LoggerFactory, model.Token, null) as IBaseBot);
            }
            return PartialView("_OnlineBots", new IndexViewModelFactory().Create(TelegramBotProvider).Bots);
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
