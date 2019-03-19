using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TL.Api.Web.Areas.ApiHelp.Controllers
{
    public class HomeController : __ApiHelpController__
    {
        public HomeController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
