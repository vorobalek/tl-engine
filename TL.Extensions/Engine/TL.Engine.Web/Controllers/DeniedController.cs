using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.Web.Controllers
{
    [AllowAnonymous]
    public class DeniedController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("index", "error", new { code = 403 });
        }
    }
}
