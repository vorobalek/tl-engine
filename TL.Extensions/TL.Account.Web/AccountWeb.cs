using TL.Engine.SDK.Extensions;

namespace TL.Account.Web
{
    public class AccountWeb : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
