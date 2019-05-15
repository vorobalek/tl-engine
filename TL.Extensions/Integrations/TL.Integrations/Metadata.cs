using System;
using TL.Engine.SDK.Modularity;

namespace TL.Integrations
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Integrations";

        protected override Version Version => new Version(1, 3, 0, 0);
    }
}
