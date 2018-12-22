using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Modules
{
    public abstract class ModuleBase : IExtension
    {
        public virtual string Name => "TL.NonameModule";

        public virtual string Description => "None";

        public virtual string Url => "http://example.com";

        public virtual string Version => "1.0.0.0";

        public virtual string Authors => "vorobalek";

        public virtual string Owner => "";

        public virtual IEnumerable<ModuleBase> SubModules => 
            ExtensionManager.GetInstances<ModuleBase>()
                .Where(m => m.Owner == Name)
                .OrderBy(sm => sm.Name);
    }
}
