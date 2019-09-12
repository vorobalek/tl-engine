using Microsoft.AspNetCore.Mvc;
using TL.JustBot.Web.Areas.JustBot.ViewModels.Home;

namespace TL.JustBot.Web.Areas.JustBot.Controllers
{
    public class HomeController : __JustBotController__
    {
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
