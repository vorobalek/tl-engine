using TL.Engine.SDK.Modularity;

namespace TL.Store.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Store.Data.EntityFramework";

        public override string Owner => "TL.Store";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";
    }
}
