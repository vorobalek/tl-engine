using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Engine.SDK.Controllers;
using TL.Engine.Web.ViewModels.Home;

namespace TL.Engine.Web.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public HomeController(IStorage storage) : base(storage)
        {
        }

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