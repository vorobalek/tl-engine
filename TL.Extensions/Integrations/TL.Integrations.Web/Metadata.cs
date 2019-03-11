using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Integrations.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Integrations.Web";

        public override string Owner => "TL.Integrations";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
            new LinkItem("/integrations", "Внешние интеграции", 1000, new string[] { "sa" }, new LinkItem[]
            {
                new LinkItem("/integrations/telegram", "Telegram Bots", 1000),
                new LinkItem("/integrations/vk", "VK Bots", 1000),
            }),
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
