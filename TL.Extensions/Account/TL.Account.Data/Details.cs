using TL.Engine.SDK.Modules;

namespace TL.Account.Data
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Account.Data";

        public override string Owner => "TL.Account";

        public override string Icon => "/Areas/Account/Styles/images/package.png";

        public override string Description =>
            $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        public override string Authors => "Alexey Vorobev";

    }
}
