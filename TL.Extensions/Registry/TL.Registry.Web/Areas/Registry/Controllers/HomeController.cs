using Microsoft.AspNetCore.Mvc;
using TL.Registry.Web.Areas.Registry.ViewModels.Home;

namespace TL.Registry.Web.Areas.Registry.Controllers
{
    public class HomeController : __RegistryController__
    {
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
