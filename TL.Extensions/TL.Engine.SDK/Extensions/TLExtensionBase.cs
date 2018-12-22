using ExtCore.Infrastructure;

namespace TL.Engine.SDK.Extensions
{
    public abstract class TLExtensionBase : IExtension
    {
        public virtual string Name => "TL.NonameModule";

        public virtual string Description => "None";

        public virtual string Url => "http://example.com";

        public virtual string Version => "1.0.0.0";

        public virtual string Authors => "vorobalek";
    }
}
