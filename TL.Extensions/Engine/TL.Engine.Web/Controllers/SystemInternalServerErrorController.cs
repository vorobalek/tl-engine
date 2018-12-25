using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TL.Engine.Web.Models;

namespace TL.Engine.Web.Controllers
{
    [Route("/SystemInternalServerError")]
    public class SystemInternalServerErrorController : Controller
    {
        public SystemInternalServerErrorController(ILogger<SystemInternalServerErrorController> logger)
        {
            Logger = logger;
        }

        public ILogger<SystemInternalServerErrorController> Logger { get; }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                Exception = HttpContext.Features.Get<IExceptionHandlerFeature>(),
                ReturnUrl = Request.Headers["Referer"].ToString(),
                StatusCode = 500
            });
        }
    }
}