using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var extensions = ExtensionManager.GetInstances<TLExtensionBase>().OrderBy(it => it.Name);
            return View(extensions);
        }
    }
}