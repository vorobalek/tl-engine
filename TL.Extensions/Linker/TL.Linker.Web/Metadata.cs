using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Linker.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Linker.Web";

        public override string Owner => "TL.Linker";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        protected override Version Version => new Version(1, 1, 0, 6);

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
            new LinkItem("/linker", "Линкер", 1000, items: new[]
            {
                new LinkItem("/linker/manager", "Менеджер", "Управление активными ссылками, сохранёнными в системе.", 1000, new string[] { Role.Sa.Name })
            }),
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
