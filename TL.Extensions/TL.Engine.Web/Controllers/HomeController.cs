using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TL.Engine.SDK.Modules;

namespace TL.Engine.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var extensions = ExtensionManager.GetInstances<ModuleBase>().Where(m => m.Owner == "").OrderBy(it => it.Name);
            return View(extensions);
        }
    }
}