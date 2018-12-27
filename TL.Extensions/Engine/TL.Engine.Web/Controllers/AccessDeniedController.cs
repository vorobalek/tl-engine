using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.Web.Controllers
{
    [AllowAnonymous]
    public class AccessDeniedController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "SystemHttpErrorCode", new { code = 403 });
        }
    }
}
