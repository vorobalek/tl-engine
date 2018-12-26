using TL.Engine.SDK.Modules;

namespace TL.Devenv
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Devenv";

        public override string Owner => "TL.Engine";

        public override string Url => "/Devenv";

        public override string DisplayName => "Разработчикам";

        public override int NavigationOrder => 200;
    }
}
