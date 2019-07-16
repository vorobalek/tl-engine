using System;
using TL.Engine.SDK.Modularity;

namespace TL.Integrations.Data.Entities
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Integrations.Data.Entities";

        public override string Owner => "TL.Integrations";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        protected override Version Version => new Version(1, 1, 0, 6);
    }
}
