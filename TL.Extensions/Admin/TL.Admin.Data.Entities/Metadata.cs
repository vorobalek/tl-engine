using TL.Engine.SDK.Modularity;

namespace TL.Admin.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Admin.Data.Entities";

        public override string Owner => "TL.Admin";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
