using System.Collections.Generic;
using TL.Engine.SDK.Modularity;

namespace TL.Translator.Web
{
    public class Metadata : MetadataBaseWeb
    {
        public override string Name => "TL.Translator.Web";

        public override string Owner => "TL.Translator";

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
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
            new NavItem("/Translator", "Переводчик", 1000),
        };
    }
}
