using TL.Engine.SDK.Modularity;

namespace TL.Store.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Store.Data";

        public override string Owner => "TL.Store";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
