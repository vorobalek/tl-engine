using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Account.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Account.Web";

        public override string Owner => "TL.Account";

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
            new MenuItem("/Account/Profile", "Публичная страница", int.MinValue, new string[] { "user" }),
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
        };
    }
}
