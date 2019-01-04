using TL.Engine.SDK.Modularity;

namespace TL.Translator.Data.Abstractions
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Translator.Data.Abstractions";

        public override string Owner => "TL.Translator";

        public override string Description =>
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
