using TL.Engine.SDK.Modularity;

namespace TL.Admin.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Admin.Data.EntityFramework";

        public override string Owner => "TL.Admin";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";
    }
}
