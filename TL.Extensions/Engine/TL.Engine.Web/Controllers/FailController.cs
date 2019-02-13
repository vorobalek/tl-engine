using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Extensions;
using TL.Engine.Data.Abstractions.Reports;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.Web.Models;

namespace TL.Engine.Web.Controllers
{
    [Route("/fail")]
    public class FailController : Controller
    {
        public FailController(IStorage storage, ILogger<FailController> logger)
        {
            Storage = storage;
            Logger = logger;
        }

        public IStorage Storage { get; }

        public ILogger<FailController> Logger { get; }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var ex = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var model = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                Message = ex?.Error?.Message,
                StackTrace = ex?.Error?.ToString(),
                ReturnUrl = Request.Headers["Referer"].ToString(),
                StatusCode = 500
            };
            if (User.Identity.IsAuthenticated)
            {
                model.Author = User.Identity.Name;
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Report(ErrorViewModel model)
        {
            string message;

            if (!string.IsNullOrWhiteSpace(model.StackTrace))
            {
                model.StackTrace = string.Join("\r\n   ", model.StackTrace.Split("   "));
            }
            if (ModelState.IsValid)
            {
                var date = DateTime.Now.ToUniversalTime();
                var report = new Report()
                {
                    Author = model.Author,
                    Description = model.Description,
                    Priority = model.Priority as ReportPriority?,
                    CreationDate = date,
                    ModifiedDate = date,
                    Message = model.Message,
                    StackTrace = model.StackTrace
                };

                if (User.Identity.IsAuthenticated)
                {
                    report.User = User.GetUser(Storage);
                }

                Storage.GetRepository<IReportRepository>().Add(report);
                Storage.Save();
                message = "Спасибо за ваш фидбек!";
            }
            else
            {
                message = "Одно или несколько полей были заполнены неверно. Ваш репорт не отправлен.";
            }
            return PartialView("_StatusMessage", message);
        }
    }
}