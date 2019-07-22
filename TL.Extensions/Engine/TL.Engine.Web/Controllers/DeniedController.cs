using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TL.Engine.Web.Models;

namespace TL.Engine.Web.Controllers
{
    [Route("/denied")]
    public class DeniedController : Controller
    {
        ILogger Logger { get; }

        public DeniedController(ILogger<ErrorController> logger)
        {
            Logger = logger;
        }

        public IActionResult Index(string returnUrl = null)
        {
            Logger.LogInformation($"Access Denied: {returnUrl ?? "not instance"}");
            return View(new ErrorViewModel
            {
                RequestId = null,
                ReturnUrl = Request.Headers["Referer"].ToString(),
                StatusCode = 403
            });
        }
    }
}
