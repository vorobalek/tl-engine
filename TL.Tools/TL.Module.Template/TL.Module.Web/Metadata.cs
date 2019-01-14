using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace $safeprojectname$
{
    public class Metadata : BaseMetadataWeb
{
        public override string Name => "$safeprojectname$";

        public override string Owner => "TL.$saferootprojectname$";

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
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
                new NavItem("/$saferootprojectname$", "$saferootprojectname$", 1000),
        };
    }
}
