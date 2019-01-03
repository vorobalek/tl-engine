using Microsoft.AspNetCore.Mvc;

namespace TL.Api.Web.Areas.Api.Controllers
{
    public class HomeController : __ApiHelpController__
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Methods()
        {
            return View();
        }

        public IActionResult Objects()
        {
            return View();
        }
    }
}
