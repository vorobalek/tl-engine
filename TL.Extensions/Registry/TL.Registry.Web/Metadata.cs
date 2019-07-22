using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Registry.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Registry.Web";

        public override string Owner => "TL.Registry";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
            new LinkItem("/registry", "Репозитории", "Файловые репозитории системы", 1000, new string[] { Role.DefaultUser.Name }, new[]
            {
                new LinkItem("/registry/files", "Все файлы", "Показать все файлы без привязки к репозиториям", 1000, new string[] { Role.Sa.Name })
            }),
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
