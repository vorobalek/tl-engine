using TL.Engine.SDK.Modularity;

namespace TL.Blog.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Blog.Data.Abstractions";

        public override string Owner => "TL.Blog";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";
    }
}
