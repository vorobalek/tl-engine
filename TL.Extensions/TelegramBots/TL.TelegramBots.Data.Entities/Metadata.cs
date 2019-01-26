using TL.Engine.SDK.Modularity;

namespace TL.TelegramBots.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.TelegramBots.Data.Entities";

        public override string Owner => "TL.TelegramBots";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
