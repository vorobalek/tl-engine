using System.Collections.Generic;
using TL.Engine.SDK.Modularity;

namespace TL.Account.Web
{
    public class Metadata : MetadataBaseWeb
    {
        public override string Name => "TL.Account.Web";

        public override string Owner => "TL.Account";

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
            new MenuItem("/Account/Profile", "Публичная страница", int.MinValue, new string[] { "user" }),
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
            new NavItem("/Account/Manage/UserGroups", "Пользователи и группы", 1000, new string[] { "sa" })
        };
    }
}
