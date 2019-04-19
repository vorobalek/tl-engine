using ExtCore.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.SystemActiveModules
{
    public class SystemActiveModulesViewModelFactory
    {
        public SystemActiveModulesViewModel Create(IHostingEnvironment environment, IConfiguration configuration)
        {
            var modules = new List<string>();

            var path = Path.Combine(environment.ContentRootPath, configuration["Extensions:Path"], "Modules");
            if (Directory.Exists(path))
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    modules.Add(directory.Split(Path.DirectorySeparatorChar).Last());
                }
            }

            return new SystemActiveModulesViewModel()
            {
                Modules = modules,
                Extensions = ExtensionManager.GetInstances<BaseMetadata>().Where(m => m.Owner == "").OrderBy(it => it.Name).ToList()
            };
        }
    }
}
