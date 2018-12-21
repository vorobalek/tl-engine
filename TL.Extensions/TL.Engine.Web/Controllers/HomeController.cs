using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}