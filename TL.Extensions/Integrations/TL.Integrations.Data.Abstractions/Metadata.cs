using TL.Engine.SDK.Modularity;

namespace TL.Integrations.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Integrations.Data.Abstractions";

        public override string Owner => "TL.Integrations";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";
    }
}
