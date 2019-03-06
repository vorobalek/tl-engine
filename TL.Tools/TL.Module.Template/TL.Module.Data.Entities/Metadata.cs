using TL.Engine.SDK.Modularity;

namespace $safeprojectname$
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "$safeprojectname$";

        public override string Owner => "TL.$saferootprojectname$";

        public override string Description =>
                $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";
    }
}
