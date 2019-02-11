using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Engine.Web.Controllers
{
    public class AlertController : BaseController
    {
        public AlertController(IStorage storage) : base(storage)
        {
        }

        [HttpPost]
        public IActionResult Index(string message)
        {
            return PartialView("_StatusMessage", message);
        }
    }
}
