using System.Collections.Generic;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.SystemActiveModules
{
    public class SystemActiveModulesViewModel
    {
        public IList<string> Modules { get; set; }
        public IList<BaseMetadata> Extensions { get; set; }
    }
}
