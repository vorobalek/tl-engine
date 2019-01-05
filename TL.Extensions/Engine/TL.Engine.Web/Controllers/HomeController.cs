using Microsoft.AspNetCore.Mvc;
using System;
using TL.Engine.Web.ViewModels.Home;

namespace TL.Engine.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }

        public IActionResult Exception()
        {
            throw new NotImplementedException("Test");
        }
    }
}