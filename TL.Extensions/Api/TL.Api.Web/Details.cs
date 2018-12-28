using TL.Engine.SDK.Modules;

namespace TL.Api.Web
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Api.Web";

        public override string Owner => "TL.Api";

        public override string Description =>
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
