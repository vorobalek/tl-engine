using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TL.Engine.Web.Models;

namespace TL.Engine.Web.Controllers
{
    [Route("/Error")]
    public class ErrorController : Controller
    {
        public ErrorController(ILogger<ErrorController> logger)
        {
            Logger = logger;
        }

        public ILogger<ErrorController> Logger { get; }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                Exception = HttpContext.Features.Get<IExceptionHandlerFeature>(),
                StatusCode = 500
            });
        }

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
                StatusCode = code
            });
        }
    }
}