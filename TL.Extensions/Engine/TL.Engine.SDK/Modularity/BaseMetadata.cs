using ExtCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Modularity
{
    public abstract class BaseMetadata
    {
        private Version MinimalVersion => new Version(0, 5, 0, 3);

        public abstract string Name { get; }

        public virtual string Description => $"Модуль системы TL Engine. {Name}.dll";

        public virtual string Authors => "";

        public virtual string Owner => "";

        public virtual IEnumerable<BaseMetadata> SubModules =>
            ExtensionManager.GetInstances<BaseMetadata>()
                .Where(m => m.Owner == Name)
                .OrderBy(sm => sm.Name);

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

        protected virtual Version Version => new Version(0, 0, 0, 0);
    }
}
