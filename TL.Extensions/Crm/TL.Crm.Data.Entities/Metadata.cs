using TL.Engine.SDK.Modularity;

namespace TL.Crm.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Crm.Data.Entities";

        public override string Owner => "TL.Crm";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
