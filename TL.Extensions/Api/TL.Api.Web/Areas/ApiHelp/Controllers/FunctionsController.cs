using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TL.Api.Web.Areas.ApiHelp.Controllers
{
    public class FunctionsController : __ApiHelpController__
    {
        public FunctionsController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
