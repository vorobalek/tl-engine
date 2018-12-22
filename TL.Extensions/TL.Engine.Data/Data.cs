using TL.Engine.SDK.Extensions;

namespace TL.Engine.Data
{
    public class Data : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
