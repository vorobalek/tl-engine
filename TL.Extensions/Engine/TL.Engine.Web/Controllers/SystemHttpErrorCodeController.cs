using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TL.Engine.Web.Models;

namespace TL.Engine.Web.Controllers
{
    [Route("/SystemHttpErrorCode")]
    public class SystemHttpErrorCodeController : Controller
    {
        public SystemHttpErrorCodeController(ILogger<SystemHttpErrorCodeController> logger)
        {
            Logger = logger;
        }

        public ILogger<SystemHttpErrorCodeController> Logger { get; }

        [AllowAnonymous]
        [HttpGet("{code}")]
        public IActionResult Index(int code)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            Logger.LogInformation($"Unexpected Status Code: {code}, OriginalPath: {reExecute?.OriginalPath ?? "not instance"}");
            return View(new ErrorViewModel
            {
                RequestId = null,
                ReturnUrl = Request.Headers["Referer"].ToString(),
                StatusCode = code
            });
        }
    }
}