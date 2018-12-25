using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TL.Engine.Web.Models;

namespace TL.Engine.Web.Controllers
{
    [Route("/StatusCode")]
    public class StatusCodeController : Controller
    {
        public StatusCodeController(ILogger<StatusCodeController> logger)
        {
            Logger = logger;
        }

        public ILogger<StatusCodeController> Logger { get; }

        [AllowAnonymous]
        [HttpGet("{code}")]
        public IActionResult Index(int code)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            Logger.LogInformation($"Unexpected Status Code: {code}, OriginalPath: {reExecute.OriginalPath}");
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                Exception = HttpContext.Features.Get<IExceptionHandlerFeature>(),
                ReturnUrl = Url.Content("/"),
                StatusCode = code
            });
        }
    }
}