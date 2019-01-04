using TL.Engine.SDK.Modularity;

namespace TL.Engine.Data
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Engine.Data";

        public override string Owner => "TL.Engine";

        public override string Description => 
            $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";

        public override string Authors => "Alexey Vorobev";
    }
}
