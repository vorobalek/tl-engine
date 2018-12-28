using TL.Engine.SDK.Modules;

namespace TL.Engine
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Engine";

        public override string DisplayName => "Ядро";
        
        public override string Description => 
            "Ядро системы TL Engine - обнаруживает и запускает модули.";

        public override string Authors => "Alexey Vorobev";
    }
}
