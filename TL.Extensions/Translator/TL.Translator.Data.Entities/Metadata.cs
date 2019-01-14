using TL.Engine.SDK.Modularity;

namespace TL.Translator.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Translator.Data.Entities";

        public override string Owner => "TL.Translator";

        public override string Description =>
            $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        public override string Authors => "Alexey Vorobev";
    }
}
