using TL.Engine.SDK.Modularity;

namespace TL.Crm.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Crm.Data.EntityFramework";

        public override string Owner => "TL.Crm";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";
    }
}
