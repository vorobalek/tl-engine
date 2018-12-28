using TL.Engine.SDK.Modules;

namespace TL.Engine.Web
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Engine.Web";

        public override string Owner => "TL.Engine";

        public override string Description => 
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
