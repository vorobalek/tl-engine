using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using TL.Engine.Data.Entities.Reports;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;
using TL.Engine.Web.Models;

namespace TL.Engine.Web.Controllers
{
    public class FailController : Controller
    {
        public FailController(IReportManager reportManager, IUserManager userManager)
        {
            ReportManager = reportManager;
            UserManager = userManager;
        }

        IUserManager UserManager { get; }

        IReportManager ReportManager { get; }

        [HttpGet]
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
        public IActionResult Index(object foo)
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
            if (!string.IsNullOrWhiteSpace(model.StackTrace))
            {
                model.StackTrace = string.Join("\r\n   ", model.StackTrace.Split("   "));
            }

            string message;
            if (ModelState.IsValid)
            {
                var report = new Report()
                {

                    Author = model.Author,
                    Description = model.Description,
                    Priority = model.Priority as ReportPriority?,
                    Message = model.Message,
                    StackTrace = model.StackTrace,
                };

                if (User.Identity.IsAuthenticated)
                {
                    report.UserId = UserManager.GetByClaims(User)?.Id;
                }

                ReportManager.Create(report);
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