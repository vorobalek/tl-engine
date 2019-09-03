using ExtCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "Core.Web";

        public override string Owner => "Core";

        public override string Description =>
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";

        protected override Version Version => new Version(1, 1, 0, 6);

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
            new LinkItem("/", "Главная", int.MinValue),
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
            new ScriptItem("//code.jquery.com/jquery-3.3.1.min.js", int.MinValue),
            new ScriptItem("//ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js", int.MinValue),
            new ScriptItem("//ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js", int.MinValue),
            new ScriptItem("//unpkg.com/popper.js@1.15.0/dist/umd/popper.min.js", int.MinValue),
            new ScriptItem("//unpkg.com/tooltip.js@1.3.2/dist/umd/tooltip.min.js", int.MinValue),
            new ScriptItem("//stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js", int.MinValue),
            new ScriptItem("//cdn.jsdelivr.net/npm/bs-custom-file-input/dist/bs-custom-file-input.min.js", int.MinValue),

            new ScriptItem("/Scripts/jquery.maskedinput.min.js", int.MinValue),
            new ScriptItem("/Scripts/site.min.js", int.MinValue),
            new ScriptItem("/Scripts/clipboard.min.js", int.MinValue),
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
            new LinkItem("Ядро", int.MaxValue, new string[] { Role.Sa.Name }, new[]
            {
                new LinkItem("/modules", "Модули", "Управление модулями системы, установка/обновление/удаление компонентов.", 1000),
                new LinkItem("/runtime", "Диспетчер", "Лог запуска, управление нагрузкой, перезапуск сервера.", 1005),
            }),
            new LinkItem("/admin", "Администрирование", "Настроки системы.", int.MaxValue - 1, new string[] { Role.Sa.Name },
                ExtensionManager
                .GetInstances<BaseMetadataWeb>(useCaching: true)
                .GroupBy(m => m.Owner)
                .OrderBy(g => g.Key)
                .SelectMany(g => g.Select(m => m))
                .Select(m => m.GetAdminItems()
                    .Select(it =>
                    {
                        if (it is NotAvailableLinkItem)
                        {
                            return new NotAvailableLinkItem(it.Url, it.Name, $"{(string.IsNullOrWhiteSpace(it.Description) ? "" : $"{it.Description} ")}({m.Owner})", it.Position, it.Roles, it.Items);
                        }
                        else
                        {
                            return new LinkItem(it.Url, it.Name, $"{(string.IsNullOrWhiteSpace(it.Description) ? "" : $"{it.Description} ")}({m.Owner})", it.Position, it.Roles, it.Items);
                        }
                    }))
                .SelectMany(it => it)),
        };

        protected override IEnumerable<LinkItem> AdminItems => new LinkItem[]
        {
            new NotAvailableLinkItem("/welcome/edit", "Настроить страницу приветствия", "Страницу приветствия можно заполнить самостоятельно, используя HTML разметку.", 1000),
            new NotAvailableLinkItem("/admin/users", "Пользователи", "Управление учётными записями пользователей.", 1000),
            new NotAvailableLinkItem("/admin/groups", "Группы", "Управление группами пользователей.", 1000),
            new NotAvailableLinkItem("/admin/roles", "Роли", "Управление ролями пользователей в системе.", 1000),
            new NotAvailableLinkItem("/admin/updating", "Обновления", "Настройка времени автоматического обновления компонентов системы.", 1000),
            new NotAvailableLinkItem("/admin/reports", "Отчёты об ошибках", "Просмотреть отчёты об ошибках, отправленных пользователями.", 1000),
            new NotAvailableLinkItem("/saas", "Режим SaaS", "Этот режим позволяет превратить ваш сервер TL Engine в систему по оказанию услуг облачного развертывания серверов TL Engine.", 1000),
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
            new StyleItem("//stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css", int.MinValue),
            new StyleItem("/Styles/css/site.min.css", int.MinValue),
            new StyleItem("/Styles/images/pack/font/flaticon.min.css", int.MinValue),
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
            new LinkItem("/welcome", "Добро пожаловать!", "Приветственная страница системы TL Engine.", int.MinValue, new string[] { Role.DefaultUser.Name }),
            new NotAvailableLinkItem("/settings", "Настройки", "Ваши личные настройки системы TL Engine.", 1000, new string[] { Role.DefaultUser.Name }),
        };
    }
}
