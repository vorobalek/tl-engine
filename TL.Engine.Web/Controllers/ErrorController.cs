using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TL.Engine.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ErrorController(ILogger<HomeController> logger)
        {
            Logger = logger;
        }

        public ILogger<HomeController> Logger { get; }

        [HttpGet("/Error/{code}")]
        public IActionResult Index(int code)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            Logger.LogInformation($"Unexpected Status Code: {code}, OriginalPath: {reExecute.OriginalPath}");
            return View(code);
        }
    }
}