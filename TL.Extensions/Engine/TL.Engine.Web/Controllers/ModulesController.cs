using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using TL.Engine.Web.ViewModels.SystemActiveModules;

namespace TL.Engine.Web.Controllers
{
    [Authorize(Roles = "sa")]
    public class ModulesController : Controller
    {
        IHostingEnvironment Environment { get; set; }

        public ModulesController(IHostingEnvironment environment)
        {
            Environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new SystemActiveModulesViewModelFactory().Create());
        }

        [HttpPost]
        public IActionResult Index(IFormFile package_file)
        {
            return View(new SystemActiveModulesViewModelFactory().Create());
        }
    }
}