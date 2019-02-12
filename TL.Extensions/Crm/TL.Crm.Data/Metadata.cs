using TL.Engine.SDK.Modularity;

namespace TL.Crm.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Crm.Data";

        public override string Owner => "TL.Crm";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
