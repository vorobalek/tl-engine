using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.Web.Controllers
{
    public class DeniedController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("index", "error", new { code = 403 });
        }
    }
}
