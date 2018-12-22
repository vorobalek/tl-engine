using TL.Engine.SDK.Extensions;

namespace TL.Account.Data.EntityFramework
{
    public class AccountDataEntityFramework : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
