using TL.Engine.SDK.Modules;

namespace TL.Devenv
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Devenv";

        public override string Owner => "TL.Engine";

        public override string Description =>
            "Окружение для разработчиков - предоставляет доступ к автособираемой API документации, новостному каналу и состоянию системы TL Engine";

        public override string Authors => "Alexey Vorobev";

        public override bool IsNavigationItem => true;

        public override int NavigationOrder => 200;

        public override string Url => "/Devenv";

        public override string DisplayName => "Разработчикам";
    }
}
