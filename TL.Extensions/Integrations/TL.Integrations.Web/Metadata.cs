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

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<MenuItem> MenuItems => new MenuItem[]
        {
            new MenuItem("/Integrations", "Интеграция с Telegram", 1000, new[] { "sa" })
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
        };
    }
}
