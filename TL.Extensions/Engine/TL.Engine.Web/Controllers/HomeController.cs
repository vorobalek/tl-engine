using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var extensions = ExtensionManager.GetInstances<MetadataBase>().Where(m => m.Owner == "").OrderBy(it => it.Name);
            return View(extensions);
        }
    }
}