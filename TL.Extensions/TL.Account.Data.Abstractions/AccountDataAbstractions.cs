using TL.Engine.SDK.Extensions;

namespace TL.Account.Data.Abstractions
{
    public class AccountDataAbstractions : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
