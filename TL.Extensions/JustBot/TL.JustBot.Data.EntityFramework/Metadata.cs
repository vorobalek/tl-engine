using TL.Engine.SDK.Modularity;

namespace TL.JustBot.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.JustBot.Data.EntityFramework";

        public override string Owner => "TL.JustBot";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";
    }
}
