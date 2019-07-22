using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Admin.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Admin.Web";

        public override string Owner => "TL.Admin";

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
            new LinkItem("/admin", "Администрирование", "Настроки системы.", int.MaxValue - 1, new string[] { Role.Sa.Name }, GetAdminItems()),
        };

        protected override IEnumerable<LinkItem> AdminItems => new[]
            {
                new LinkItem("/admin/ugr", "Пользователи и группы", "Управление учетными записями, группами пользователей и ролями системы.", 1000),
            };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
