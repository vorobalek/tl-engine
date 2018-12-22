using TL.Engine.SDK.Extensions;

namespace TL.Engine.SDK
{
    public class SDK : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
