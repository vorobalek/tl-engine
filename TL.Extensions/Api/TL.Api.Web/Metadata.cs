using System;
using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Api.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Api.Web";

        public override string Owner => "TL.Api";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        protected override Version Version => new Version(1, 1, 0, 5);

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
            new LinkItem("/apihelp", "API", "Документация для интеграции с внешними сервисами.", 1000),
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
            new LinkItem("/apihelp/settings", "Настройки API", "Приватные токен-ключи, логи, статистика, критерии доступа.", 1010, new[] { "sa" }),
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
