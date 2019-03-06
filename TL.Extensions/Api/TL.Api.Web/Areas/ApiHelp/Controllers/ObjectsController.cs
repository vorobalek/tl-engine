using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TL.Api.Web.Areas.Api.Controllers
{
    public class ObjectsController : __ApiHelpController__
    {
        public ObjectsController(IStorage storage) : base(storage)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
