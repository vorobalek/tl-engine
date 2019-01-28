using TL.Engine.SDK.Modularity;

namespace TL.Integrations.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Integrations.Data";

        public override string Owner => "TL.Integrations";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
