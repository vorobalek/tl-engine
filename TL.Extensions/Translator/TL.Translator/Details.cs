using TL.Engine.SDK.Modules;

namespace TL.Translator
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Translator";

        public override string Owner => "TL.Engine";

        public override string Url => "/Translator";

        public override string DisplayName => "Translator";

        public override int NavigationOrder => 1000;
    }
}
