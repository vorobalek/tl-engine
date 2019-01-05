using System.Collections.Generic;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web
{
    public class Metadata : MetadataBaseWeb
    {
        public override string Name => "TL.Engine";

        public override string Description => 
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";

        public override IEnumerable<Style> Styles => new Style[]
        {
            new Style("//stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css", 1000),
            new Style("/Styles/css/site.min.css", 1000),
            new Style("/Styles/images/pack/font/flaticon.min.css", 1000),
        };

        public override IEnumerable<Script> Scripts => new Script[]
        {
            new Script("//code.jquery.com/jquery-3.3.1.min.js", 1000),
            new Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js", 1000),
            new Script("//ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js", 1000),
            new Script("//stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js", 1000),
            new Script("//stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.bundle.min.js", 1000),
            new Script("//cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js", 1000),

            new Script("/Scripts/tooltip.min.js", 1000),
            new Script("/Scripts/site.min.js", 1000),
            new Script("/Scripts/clipboard.min.js", 1000),
        };

        public override IEnumerable<MenuItem> MenuItems => new MenuItem[]
        {
            new MenuItem("/Home/Exception", "Проверить исключения", 1000)
        };

        public override IEnumerable<NavItem> NavItems => new NavItem[]
        {
            new NavItem("/", "Главная", int.MinValue),
            new NavItem("/SystemActiveModules", "Модули", int.MinValue, new string[] { "sa" }),
        };
    }
}
