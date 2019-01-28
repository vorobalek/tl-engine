using System.Collections.Generic;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.SDK.Modularity
{
    public abstract class BaseMetadataWeb : BaseMetadata
    {
        public abstract IEnumerable<LinkItem> NavbarItems { get; }

        public abstract IEnumerable<ScriptItem> ScriptItems { get; }

        public abstract IEnumerable<LinkItem> SidebarItems { get; }

        public abstract IEnumerable<StyleItem> StyleItems { get; }

        public abstract IEnumerable<LinkItem> UserNavbarItems { get; }
    }
}
