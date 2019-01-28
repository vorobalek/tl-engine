using System.Collections.Generic;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web
{
    public class Metadata : BaseMetadataWeb
    {
        public override string Name => "TL.Engine";

        public override string Description => 
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";

        public override IEnumerable<LinkItem> NavbarItems => new LinkItem[]
        {
            new LinkItem("/", "Главная", int.MinValue),
        };

        public override IEnumerable<ScriptItem> ScriptItems => new ScriptItem[]
        {
            new ScriptItem("//code.jquery.com/jquery-3.3.1.min.js", int.MinValue),
            new ScriptItem("//ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js", int.MinValue),
            new ScriptItem("//ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js", int.MinValue),
            new ScriptItem("//stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.bundle.min.js", int.MinValue),
            new ScriptItem("//cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js", int.MinValue),

            new ScriptItem("/Scripts/tooltip.min.js", int.MinValue),
            new ScriptItem("/Scripts/site.min.js", int.MinValue),
            new ScriptItem("/Scripts/clipboard.min.js", int.MinValue),
        };

        public override IEnumerable<LinkItem> SidebarItems => new LinkItem[]
        {
            new LinkItem("/Home/Exception", "Проверить исключения", 0, new string[] { "sa" }),
        };

        public override IEnumerable<StyleItem> StyleItems => new StyleItem[]
        {
            new StyleItem("//stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css", int.MinValue),
            new StyleItem("/Styles/css/site.min.css", int.MinValue),
            new StyleItem("/Styles/images/pack/font/flaticon.min.css", int.MinValue),
        };

        public override IEnumerable<LinkItem> UserNavbarItems => new LinkItem[]
        {
            new LinkItem("/SystemActiveModules", "Модули", int.MinValue, new string[] { "sa" }),
        };
    }
}
