using TL.Engine.SDK.Modularity;

namespace TL.Api.Data.Entities
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Api.Data.Entities";

        public override string Owner => "TL.Api";

        public override string Description =>
            $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        public override string Authors => "Alexey Vorobev";
    }
}
