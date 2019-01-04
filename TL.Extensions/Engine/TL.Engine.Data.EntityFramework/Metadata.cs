using TL.Engine.SDK.Modularity;

namespace TL.Engine.Data.EntityFramework
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Engine.Data.EntityFramework";

        public override string Owner => "TL.Engine";

        public override string Description => 
            $"Модуль провайдера баз данных. Промежуточный слой, описывающий структуры таблиц в базе данных для сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
