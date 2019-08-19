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
            new LinkItem("/registry", "Репозитории", "Файловые репозитории системы", 1000, new string[] { Role.DefaultUser.Name }),
        };

        protected override IEnumerable<LinkItem> AdminItems => new LinkItem[]
        {
            new NotAvailableLinkItem("/registry/files", "Все файлы", "Показать все файлы без привязки к репозиториям", 1000),
            new NotAvailableLinkItem("/registry/permissions", "Права доступа к репозиториям", "Управление правами доступа к репозиториям", 1000),
            new NotAvailableLinkItem("/registry/folders/permissions", "Права доступа к каталогам репозиториев", "Управление правами доступа к каталогам репозиториев", 1000),
            new NotAvailableLinkItem("/registry/files/permissions", "Права доступа к файлам репозиториев", "Управление правами доступа к файлам репозиториев", 1000),
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
