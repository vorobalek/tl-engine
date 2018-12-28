using TL.Engine.SDK.Modules;

namespace TL.Translator.Web
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Translator.Web";

        public override string Owner => "TL.Translator";

        public override string Description =>
            $"Модуль веб-оболочки. Реализует логику представлений, моделей и обработку сущностей {Owner}.";

        public override string Authors => "Alexey Vorobev";
    }
}
