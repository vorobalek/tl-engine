using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TL.Admin.Web.Areas.Admin.ViewModels.Home;

namespace TL.Admin.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "sa")]
    public class HomeController : __AdminController__
    {
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
