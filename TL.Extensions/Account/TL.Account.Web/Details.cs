using TL.Engine.SDK.Modules;

namespace TL.Account.Web
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Account.Web";

        public override string Owner => "TL.Account";

        public override string Description =>
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
