using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Engine.Web.Controllers
{
    public class AlertController : BaseController
    {
        [HttpPost]
        public IActionResult Index(string message)
        {
            return PartialView("_StatusMessage", message);
        }
    }
}
