using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Services;
using TL.Engine.Web.Areas.Admin.ViewModels.Home;

namespace TL.Engine.Web.Areas.Admin.Controllers
{
    public class HomeController : __AdminController__
    {
        IActivatorService Activator { get; }

        public HomeController(IActivatorService activator)
        {
            Activator = activator;
        }

        public IActionResult Index()
        {
            return View(new IndexViewModel(Activator));
        }
    }
}
