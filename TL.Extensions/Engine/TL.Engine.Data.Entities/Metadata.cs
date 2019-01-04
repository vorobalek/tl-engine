using TL.Engine.SDK.Modularity;

namespace TL.Engine.Data.Entities
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Engine.Data.Entities";

        public override string Owner => "TL.Engine";

        public override string Description => 
            $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        public override string Authors => "Alexey Vorobev";
    }
}
