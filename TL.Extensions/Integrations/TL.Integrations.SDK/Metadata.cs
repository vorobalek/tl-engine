using System;
using TL.Engine.SDK.Modularity;

namespace TL.Integrations.SDK
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Integrations.SDK";

        public override string Owner => "TL.Integrations";

        protected override Version Version => new Version(1, 1, 0, 2);
    }
}
