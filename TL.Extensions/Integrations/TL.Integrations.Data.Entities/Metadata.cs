using TL.Engine.SDK.Modularity;

namespace TL.Integrations.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Integrations.Data.Entities";

        public override string Owner => "TL.Integrations";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
