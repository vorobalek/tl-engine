using TL.Engine.SDK.Modularity;

namespace TL.Account.Data.Abstractions
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Account.Data.Abstractions";

        public override string Owner => "TL.Account";

        public override string Description =>
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
