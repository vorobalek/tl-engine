using TL.Engine.SDK.Modularity;

namespace $safeprojectname$
{
    public class Metadata : MetadataBase
{
        public override string Name => "$safeprojectname$";

        public override string Owner => "TL.$saferootprojectname$";

        public override string Description =>
                $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";
    }
}
