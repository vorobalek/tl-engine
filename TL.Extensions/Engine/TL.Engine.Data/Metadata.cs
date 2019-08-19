using System;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "Core.Data";

        public override string Owner => "Core";

        public override string Description => 
            $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        public override string Authors => "Alexey Vorobev";

        protected override Version Version => new Version(1, 1, 0, 6);
    }
}
