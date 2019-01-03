using TL.Engine.SDK.Modules;

namespace TL.Devenv.Data
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Devenv.Data";

        public override string Owner => "TL.Devenv";

        public override string Icon => "/Areas/Devenv/Styles/images/package.png";

        public override string Description =>
            $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        public override string Authors => "Alexey Vorobev";
    }
}
