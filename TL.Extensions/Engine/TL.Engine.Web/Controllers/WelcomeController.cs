using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;
using TL.Engine.Web.ViewModels.Welcome;

namespace TL.Engine.Web.Controllers
{
    public class WelcomeController : BaseController
    {
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
