using TL.Engine.SDK.Modules;

namespace TL.Account
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Account";

        public override string Owner => "TL.Engine";

        public override string Url => "/Account";

        public override string DisplayName => "Аккаунт";

        public override int NavigationOrder => 100;
    }
}
