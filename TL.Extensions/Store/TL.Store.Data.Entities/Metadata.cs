using TL.Engine.SDK.Modularity;

namespace TL.Store.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Store.Data.Entities";

        public override string Owner => "TL.Store";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
