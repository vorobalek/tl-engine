using TL.Engine.SDK.Extensions;

namespace TL.Account
{
    public class Account : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
