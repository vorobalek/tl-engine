using System;
using TL.Engine.SDK.Modularity;

namespace TL.Account.SDK
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Account.SDK";

        public override string Owner => "TL.Account";

        protected override Version Version => new Version(1, 1, 0, 6);
    }
}
