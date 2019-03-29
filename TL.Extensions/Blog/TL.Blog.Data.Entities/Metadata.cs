using TL.Engine.SDK.Modularity;

namespace TL.Blog.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Blog.Data.Entities";

        public override string Owner => "TL.Blog";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
