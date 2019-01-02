using ExtCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Modules
{
    public abstract class ModuleBase
    {
        private Version MinimalVersion => new Version(0, 1, 0, 43);

        public Version GetVersion()
        {
            int compareValue = Version.CompareTo(MinimalVersion);
            if (compareValue < 0)
            {
                return MinimalVersion;
            }
            else
            {
                return Version;
            }
        }

        public virtual string Name => "TL.NonameModule";

        public virtual string Description => $"Модуль системы TL Engine. {Name}.dll";

        public virtual string Authors => "";

        public virtual Version Version => new Version(0, 0, 0, 0);

        public virtual string Owner => "";

        public virtual IEnumerable<ModuleBase> SubModules =>
            ExtensionManager.GetInstances<ModuleBase>()
                .Where(m => m.Owner == Name)
                .OrderBy(sm => sm.Name);


        public virtual bool IsNavigationItem => false;

        public virtual int NavigationOrder => int.MaxValue;

        public virtual string Url => "";

        public virtual string DisplayName => Name;

        public virtual string Icon => "/Styles/images/package.png";
    }
}
