using TL.Engine.SDK.Modularity;

namespace TL.TelegramBots.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.TelegramBots.Data.EntityFramework";

        public override string Owner => "TL.TelegramBots";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";
    }
}
