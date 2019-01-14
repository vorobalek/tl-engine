using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Translator.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Translator.Web";

        public override string Owner => "TL.Translator";

        public override string Description =>
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<MenuItem> MenuItems => new MenuItem[]
        {
            new MenuItem("/Translator/History", "История переводов", 1000, new string[] { "user", "sa" }),
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
            new NavItem("/Translator", "Переводчик", 1000),
        };
    }
}
