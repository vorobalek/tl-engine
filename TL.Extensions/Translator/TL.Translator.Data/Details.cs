using TL.Engine.SDK.Modules;

namespace TL.Translator.Data
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Translator.Data";

        public override string Owner => "TL.Translator";

        public override string Icon => "/Areas/Translator/Styles/images/package.png";

        public override string Description =>
            $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        public override string Authors => "Alexey Vorobev";
    }
}
