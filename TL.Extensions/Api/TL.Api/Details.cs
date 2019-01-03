using TL.Engine.SDK.Modules;

namespace TL.Api
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Api";

        public override string Owner => "TL.Engine";

        public override string Description =>
            "Предоставляет открые методы для взаимодействия с системой TL Engine";

        public override string Authors => "Alexey Vorobev";

        public override bool IsNavigationItem => true;

        public override int NavigationOrder => 200;

        public override string Url => "/ApiHelp";

        public override string DisplayName => "Api";

        public override string Icon => "/Areas/ApiHelp/Styles/images/package.png";
    }
}
