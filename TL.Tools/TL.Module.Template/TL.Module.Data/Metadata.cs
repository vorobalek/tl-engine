using TL.Engine.SDK.Modularity;

namespace $safeprojectname$
{
    public class Metadata : BaseMetadata
{
        public override string Name => "$safeprojectname$";

        public override string Owner => "TL.$saferootprojectname$";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
