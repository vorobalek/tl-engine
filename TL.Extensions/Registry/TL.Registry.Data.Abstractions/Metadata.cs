using TL.Engine.SDK.Modularity;

namespace TL.Registry.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Registry.Data.Abstractions";

        public override string Owner => "TL.Registry";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";
    }
}
