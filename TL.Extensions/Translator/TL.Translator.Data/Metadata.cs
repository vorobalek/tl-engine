using TL.Engine.SDK.Modularity;

namespace TL.Translator.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Translator.Data";

        public override string Owner => "TL.Translator";

        public override string Description =>
            $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        public override string Authors => "Alexey Vorobev";
    }
}
