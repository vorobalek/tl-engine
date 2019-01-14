using System.Collections.Generic;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.SDK.Modularity
{
    public abstract class BaseMetadataWeb : BaseMetadata
    {
        public abstract IEnumerable<StyleItem> StyleItems { get; }

        public abstract IEnumerable<ScriptItem> ScriptItems { get; }

        public abstract IEnumerable<MenuItem> MenuItems { get; }

        public abstract IEnumerable<NavItem> NavItems { get; }
    }
}
