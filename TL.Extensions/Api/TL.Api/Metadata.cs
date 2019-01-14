using TL.Engine.SDK.Modularity;

namespace TL.Api
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Api";

        public override string Owner => "";

        public override string Description =>
            "Предоставляет открые методы для взаимодействия с системой TL Engine";

        public override string Authors => "Alexey Vorobev";
    }
}
