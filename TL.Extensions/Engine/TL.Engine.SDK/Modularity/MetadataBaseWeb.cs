using System.Collections.Generic;

namespace TL.Engine.SDK.Modularity
{
    public abstract class MetadataBaseWeb : MetadataBase
    {
        public abstract IEnumerable<Style> Styles { get; }

        public abstract IEnumerable<Script> Scripts { get; }

        public abstract IEnumerable<MenuItem> MenuItems { get; }

        public abstract IEnumerable<NavItem> NavItems { get; }
    }
}
