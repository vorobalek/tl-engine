using TL.Engine.SDK.Modularity;

namespace TL.Admin.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Admin.Data.Abstractions";

        public override string Owner => "TL.Admin";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";
    }
}
