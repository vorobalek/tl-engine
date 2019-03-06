using TL.Engine.SDK.Modularity;

namespace TL.Crm.Data.Abstractions
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Crm.Data.Abstractions";

        public override string Owner => "TL.Crm";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";
    }
}
