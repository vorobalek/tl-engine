using System.Collections.Generic;
using TL.Engine.SDK.Modularity;

namespace $safeprojectname$
{
    public class Metadata : MetadataBaseWeb
{
        public override string Name => "$safeprojectname$";

        public override string Owner => "TL.$saferootprojectname$";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override IEnumerable<Style> Styles => new Style[]
        {
        };

        public override IEnumerable<Script> Scripts => new Script[]
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
