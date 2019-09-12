using TL.Engine.SDK.Modularity;

namespace TL.JustBot.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.JustBot.Data";

        public override string Owner => "TL.JustBot";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
