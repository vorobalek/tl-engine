using System;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.SDK
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Engine.SDK";

        public override string Owner => "TL.Engine";

        protected override Version Version => new Version(1, 1, 0, 5);
    }
}
