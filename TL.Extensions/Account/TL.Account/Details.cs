using TL.Engine.SDK.Modules;

namespace TL.Account
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Account";

        public override string Owner => "TL.Engine";

        public override string Description =>
            "Отвечает за авторизацию и аутентификацию.";

        public override string Authors => "Alexey Vorobev";

        public override bool IsNavigationItem => false;

        public override int NavigationOrder => 100;

        public override string Url => "/Account";

        public override string DisplayName => "Аккаунт";

        public override string Icon => "/Areas/Account/Styles/images/package.png";
    }
}
