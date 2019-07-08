using TL.Engine.SDK.Modularity;

namespace TL.Registry.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Registry.Data.EntityFramework";

        public override string Owner => "TL.Registry";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";
    }
}
