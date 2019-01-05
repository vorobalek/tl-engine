using Microsoft.AspNetCore.Mvc;
using TL.Engine.Web.ViewModels.SystemActiveModules;

namespace TL.Engine.Web.Controllers
{
    public class SystemActiveModulesController : Controller
    {
        public IActionResult Index()
        {
            return View(new SystemActiveModulesViewModelFactory().Create());
        }
    }
}