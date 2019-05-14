using Microsoft.AspNetCore.Mvc;

namespace TL.Api.Web.Areas.ApiHelp.Controllers
{
    public class HomeController : __ApiHelpController__
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
