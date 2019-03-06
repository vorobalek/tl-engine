using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Api.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Api.Web";

        public override string Owner => "TL.Api";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
            new LinkItem("/apihelp", "API", 1000),
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
