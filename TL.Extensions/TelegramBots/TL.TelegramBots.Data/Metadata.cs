using TL.Engine.SDK.Modularity;

namespace TL.TelegramBots.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.TelegramBots.Data";

        public override string Owner => "TL.TelegramBots";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
