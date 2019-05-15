using System;
using TL.Engine.SDK.Modularity;

namespace TL.Api
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Api";

        protected override Version Version => new Version(1, 3, 0, 0);
    }
}
