using System;
using TL.Engine.SDK.Modules;

namespace $safeprojectname$
{
    public class Details : ModuleBase
    {
        public override string Name => "$safeprojectname$";

        public override string Owner => "TL.$saferootprojectname$";

        public override string Icon => "/Areas/$saferootprojectname$/Styles/images/package.png";

        public override string Description =>
                $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";
    }
}
