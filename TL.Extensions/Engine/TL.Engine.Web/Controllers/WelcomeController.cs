using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;
using TL.Engine.Web.ViewModels.Welcome;

namespace TL.Engine.Web.Controllers
{
    public class WelcomeController : BaseController
    {
        public WelcomeController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
