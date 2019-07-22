using Microsoft.AspNetCore.Mvc;
using TL.Engine.Web.Areas.Admin.ViewModels.Home;

namespace TL.Engine.Web.Areas.Admin.Controllers
{
    public class HomeController : __AdminController__
    {
        public IActionResult Index()
        {
            return View(new IndexViewModel());
        }
    }
}
