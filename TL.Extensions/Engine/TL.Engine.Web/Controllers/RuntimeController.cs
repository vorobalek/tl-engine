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
            return PartialView("_Progress");
        }

        [Authorize(Roles = "sa")]
        [HttpPost]
        public IActionResult Restart()
        {
            ApplicationLifetime.StopApplication();
            return PartialView("_StatusMessage", "Отключение сервера! Обновите страницу!");
        }
    }
}