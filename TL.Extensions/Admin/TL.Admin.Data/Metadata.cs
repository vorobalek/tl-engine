using TL.Engine.SDK.Modularity;

namespace TL.Admin.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Admin.Data";

        public override string Owner => "TL.Admin";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
