using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
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

        protected override Version Version => new Version(1, 1, 0, 6);

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
            new LinkItem("/account/profile", "Публичная страница", "Ваша персональная страница в системе", int.MinValue + 10, new string[] { Role.DefaultUser.Name }),
        };

        protected override IEnumerable<LinkItem> AdminItems => new LinkItem[]
        {
            new NotAvailableLinkItem("/account/relationships/", "Связи пользователей", "Визуализация связей между пользователями, настройки автоматических подписок", 1000),
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
