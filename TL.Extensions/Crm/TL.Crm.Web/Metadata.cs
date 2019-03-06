using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Crm.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Crm.Web";

        public override string Owner => "TL.Crm";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
            new LinkItem("/crm", "Работа с клиентами", 500, new[] { "sa" }),
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
