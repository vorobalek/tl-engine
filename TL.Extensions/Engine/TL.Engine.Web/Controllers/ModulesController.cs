using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.IO.Compression;
using System.Linq;
using TL.Engine.SDK.Controllers;
using TL.Engine.SDK.Services;
using TL.Engine.Web.ViewModels.SystemActiveModules;

namespace TL.Engine.Web.Controllers
{
    [Authorize(Roles = "sa")]
    public class ModulesController : BaseController
    {
        IHostingEnvironment Environment { get; set; }

        IConfiguration Configuration { get; set; }

        IActivatorService Activator { get; }

        public ModulesController(IHostingEnvironment environment, IConfiguration configuration, IActivatorService activator)
        {
            Environment = environment;
            Configuration = configuration;
            Activator = activator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new SystemActiveModulesViewModelFactory().Create(Environment, Configuration, Activator));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(IFormFile package_file)
        {
            var parts = package_file.FileName.Split('.');
            if (parts.Last() == "tle")
            {
                using (var package = new ZipArchive(package_file.OpenReadStream()))
                {
                    var path = Path.Combine(Environment.ContentRootPath, Configuration["Extensions:Path"], "Modules");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    var name = package_file.FileName.Substring(0, package_file.FileName.Length - 4);

                    if (package.GetEntry($"{name}/") != null)
                    {
                        package.ExtractToDirectory(path, true);
                    }
                    else
                    {
                        ModelState.AddModelError("package_file", "Пакет поврежден, либо не корректен");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("package_file", "Файл имел неверное расширение. Требуется .tle");
            }
            return View(new SystemActiveModulesViewModelFactory().Create(Environment, Configuration, Activator));
        }

        [HttpPost]
        public IActionResult Remove(string name)
        {
            var dirName = name.Substring(3);
            var path = Path.Combine(Environment.ContentRootPath, Configuration["Extensions:Path"], "Modules", dirName);
            if (!Directory.Exists(path))
            {
                return PartialView("_StatusMessage", $"Модуль {name} нельзя удалить");
            }

            Directory.Delete(path, true);
            return PartialView("_StatusMessage", $"Модуль {name} удалён. Перезапустите систему!");
        }
    }
}