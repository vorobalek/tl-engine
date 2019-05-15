using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Services;

namespace TL.Engine.Controllers
{
    public class RuntimeController : Controller
    {
        IStartupService StartupService { get; }
        public RuntimeController(IStartupService startupService)
        {
            StartupService = startupService;
        }

        public IActionResult Index()
        {
            if (!StartupService.IsOk || (User.Identity.IsAuthenticated && User.IsInRole("sa")))
            {
                return View();
            }
            return RedirectToAction("index", "error", 404);
        }
    }
}