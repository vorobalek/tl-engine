using TL.Engine.SDK.Modules;

namespace $safeprojectname$
{
    public class Details : ModuleBase
    {
        public override string Name => "$safeprojectname$";

        public override string Owner => "TL.$saferootprojectname$";

        public override string Description =>
            $"Модуль абстракций данных. Промежуточный слой интерфейсов, описывающих методы работы, допустимые с данными модуля {Owner}.";
    }
}
