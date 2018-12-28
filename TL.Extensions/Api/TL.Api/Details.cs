using TL.Engine.SDK.Modules;

namespace TL.Api
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Api";

        public override string Owner => "TL.Engine";

        public override string Description =>
            "Предоставляет открые методы для взаимодействия с системой TL Engine";

        public override string Authors => "Alexey Vorobev";
    }
}
