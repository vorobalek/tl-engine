using TL.Engine.SDK.Modularity;

namespace TL.JustBot.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.JustBot.Data.Entities";

        public override string Owner => "TL.JustBot";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
