using ExtCore.Infrastructure;
using System.Linq;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.SystemActiveModules
{
    public class SystemActiveModulesViewModelFactory
    {
        public SystemActiveModulesViewModel Create()
        {
            return new SystemActiveModulesViewModel()
            {
                Modules = ExtensionManager.GetInstances<MetadataBase>().Where(m => m.Owner == "").OrderBy(it => it.Name).ToList()
            };
        }
    }
}
