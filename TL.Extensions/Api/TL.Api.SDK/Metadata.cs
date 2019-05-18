using System;
using TL.Engine.SDK.Modularity;

namespace TL.Api.SDK
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Api.SDK";

        public override string Owner => "TL.Api";

        protected override Version Version => new Version(1, 1, 0, 2);
    }
}
