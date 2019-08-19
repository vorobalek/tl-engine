using System;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "Core.Data.Entities";

        public override string Owner => "Core";

        public override string Description => 
            $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        public override string Authors => "Alexey Vorobev";

        protected override Version Version => new Version(1, 1, 0, 6);
    }
}
