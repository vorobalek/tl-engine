using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.Web.Areas.Admin.Controllers
{
    public class UsersController : __AdminController__
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
