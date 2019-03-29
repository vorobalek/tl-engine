using TL.Engine.SDK.Modularity;

namespace TL.Blog.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Blog.Data.EntityFramework";

        public override string Owner => "TL.Blog";

        public override string Description =>
                $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";
    }
}
