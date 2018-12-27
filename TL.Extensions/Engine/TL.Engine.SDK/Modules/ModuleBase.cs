using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Modules
{
    public abstract class ModuleBase : IExtension
    {
        public virtual string Name => "TL.NonameModule";

        public virtual string Description => $"Модуль системы TL Engine. {Name}.dll";

        public virtual string Version => "1.0.0.0";

        public virtual string Authors => "vorobalek";

        public virtual string Owner => "";

        public virtual string Url => "";

        public virtual string DisplayName => "";

        public virtual int NavigationOrder => 0;

        public virtual bool IsNavigationItem => !string.IsNullOrWhiteSpace(DisplayName) && !string.IsNullOrWhiteSpace(Url);

        public virtual string Icon => "/Styles/images/package.png";

        public virtual IEnumerable<ModuleBase> SubModules => 
            ExtensionManager.GetInstances<ModuleBase>()
                .Where(m => m.Owner == Name)
                .OrderBy(sm => sm.Name);
    }
}
