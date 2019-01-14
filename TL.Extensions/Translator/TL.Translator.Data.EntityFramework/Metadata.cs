using TL.Engine.SDK.Modularity;

namespace TL.Translator.Data.EntityFramework
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Translator.Data.EntityFramework";

        public override string Owner => "TL.Translator";

        public override string Description =>
            $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
