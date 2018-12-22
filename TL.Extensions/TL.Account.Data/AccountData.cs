using TL.Engine.SDK.Extensions;

namespace TL.Account.Data
{
    public class AccountData : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
