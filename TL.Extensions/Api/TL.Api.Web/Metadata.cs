using System.Collections.Generic;
using TL.Engine.SDK.Modularity;

namespace TL.Api.Web
{
    public class Metadata : MetadataBaseWeb
    {
        public override string Name => "TL.Api.Web";

        public override string Owner => "TL.Api";

        public override string Description =>
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";

        public override IEnumerable<Style> Styles => new Style[]
        {
        };

        public override IEnumerable<Script> Scripts => new Script[]
        {
        };

        public override IEnumerable<MenuItem> MenuItems => new MenuItem[]
        {
            new MenuItem("/ApiHelp", "Введение в API", 100),
            new MenuItem("/ApiHelp/Methods", "Методы API", 101),
            new MenuItem("/ApiHelp/Objects", "Объекты API", 102),
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
            new NavItem("/ApiHelp", "Api", 1000),
        };
    }
}
