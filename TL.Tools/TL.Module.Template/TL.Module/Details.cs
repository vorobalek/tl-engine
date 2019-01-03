using TL.Engine.SDK.Modules;

namespace TL.$saferootprojectname$
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.$saferootprojectname$";

        public override string Owner => "TL.Engine";

        public override bool IsNavigationItem => true;

        public override int NavigationOrder => 1000;

        public override string Url => "/$saferootprojectname$";

        public override string DisplayName => "$saferootprojectname$";

        public override string Icon => "/Areas/$saferootprojectname$/Styles/images/package.png";
    }
}
