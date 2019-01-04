using TL.Engine.SDK.Modularity;

namespace TL.Api.Data.Abstractions
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Api.Data.Abstractions";

        public override string Owner => "TL.Api";

        public override string Description =>
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
