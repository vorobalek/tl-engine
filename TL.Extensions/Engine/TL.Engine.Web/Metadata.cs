using System;
using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Engine.Web";

        public override string Owner => "TL.Engine";

        public override string Description => 
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";

        protected override Version Version => new Version(1, 1, 0, 5);

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
            new LinkItem("/welcome", "Добро пожаловать!", int.MinValue, new string[] { "user" }),
            new LinkItem("Система", 2000, new[] { "sa" }, new[]
            {
                new LinkItem("/modules", "Управление модулями", 1000, new string[] { "sa" }),
                new LinkItem("/runtime", "Диспетчер системы", "Лог запуска, управление нагрузкой, перезапуск сервера.", 1005, new string[] { "sa" }),
                new LinkItem("/home/exception", "Проверить исключения", 1100, new string[] { "sa" })
            })
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
            new StyleItem("//stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css", int.MinValue),
            new StyleItem("/Styles/css/site.min.css", int.MinValue),
            new StyleItem("/Styles/images/pack/font/flaticon.min.css", int.MinValue),
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
        };
    }
}
