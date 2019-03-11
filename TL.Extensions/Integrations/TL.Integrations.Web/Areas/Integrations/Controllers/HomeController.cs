using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Integrations.Web.Areas.Integrations.ViewModels.Home;

namespace TL.Integrations.Web.Areas.Integrations.Controllers
{
    public class HomeController : __IntegrationsController__
    {
        public HomeController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
