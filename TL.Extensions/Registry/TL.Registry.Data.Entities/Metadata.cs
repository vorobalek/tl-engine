using TL.Engine.SDK.Modularity;

namespace TL.Registry.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Registry.Data.Entities";

        public override string Owner => "TL.Registry";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
