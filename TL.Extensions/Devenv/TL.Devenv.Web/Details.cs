using System;
using TL.Engine.SDK.Modules;

namespace TL.Devenv.Web
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Devenv.Web";

        public override string Owner => "TL.Devenv";

        public override string Description =>
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
