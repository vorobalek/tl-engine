using TL.Engine.SDK.Modules;

namespace TL.Translator
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Translator";

        public override string Owner => "TL.Engine";

        public override string Description =>
            "Учебный модуль курсового проекта - Переводчик";

        public override string Authors => "Alexey Vorobev";

        public override bool IsNavigationItem => true;

        public override int NavigationOrder => 1000;

        public override string Url => "/Translator";

        public override string DisplayName => "Translator";
    }
}
