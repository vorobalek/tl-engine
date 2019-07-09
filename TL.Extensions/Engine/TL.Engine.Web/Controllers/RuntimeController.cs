using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Services;

namespace TL.Engine.Web.Controllers
{
    public class RuntimeController : Controller
    {
        IStartupService StartupService { get; }
        IApplicationLifetime ApplicationLifetime { get; }
        public RuntimeController(IStartupService startupService, IApplicationLifetime applicationLifetime)
        {
            StartupService = startupService;
            ApplicationLifetime = applicationLifetime;
        }

        public IActionResult Index()
        {
            if (!StartupService.IsOk || (User.Identity.IsAuthenticated && User.IsInRole("sa")))
            {
                return View();
            }
            return RedirectToAction("index", "error", 404);
        }

        [HttpPost]
        public IActionResult Update()
        {
            if (!StartupService.IsReady || User.IsInRole("sa"))
            {
                return PartialView("_Progress");
            }
            return PartialView("_StatusMessage", "Отказано в доступе!");
        }

#if DEBUG
        [HttpPost]
        public IActionResult MoveNext()
        {
            if (!StartupService.IsReady || User.IsInRole("sa"))
            {
                StartupService.CanMoveNext = true;
                return PartialView("_StatusMessage", $"Переходим к шагу: \"{StartupService.NextDescription}\"");
            }
            return PartialView("_StatusMessage", "Отказано в доступе!");
        }

        [HttpPost]
        public IActionResult SkipAll()
        {
            if (!StartupService.IsReady || User.IsInRole("sa"))
            {
                StartupService.SkipAll = true;
                return PartialView("_StatusMessage", "Пропускаем отладку.");
            }
            return PartialView("_StatusMessage", "Отказано в доступе!");
        }

        [HttpPost]
        public IActionResult StopSkipAll()
        {
            if (!StartupService.IsReady || User.IsInRole("sa"))
            {
                StartupService.SkipAll = false;
                return PartialView("_StatusMessage", "Возобновляем отладку.");
            }
            return PartialView("_StatusMessage", "Отказано в доступе!");
        }
#endif

        [Authorize(Roles = "sa")]
        [HttpPost]
        public IActionResult Restart()
        {
            ApplicationLifetime.StopApplication();
            return PartialView("_StatusMessage", "Отключение сервера! Обновите страницу!");
        }
    }
}