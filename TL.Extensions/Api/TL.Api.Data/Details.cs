using TL.Engine.SDK.Modules;

namespace TL.Api.Data
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Api.Data";

        public override string Owner => "TL.Api";

        public override string Icon => "/Areas/Api/Styles/images/package.png";

        public override string Description =>
            $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        public override string Authors => "Alexey Vorobev";
    }
}
