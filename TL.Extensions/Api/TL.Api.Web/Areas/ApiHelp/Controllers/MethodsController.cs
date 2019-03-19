using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TL.Api.Web.Areas.ApiHelp.Controllers
{
    public class MethodsController : __ApiHelpController__
    {
        public MethodsController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
