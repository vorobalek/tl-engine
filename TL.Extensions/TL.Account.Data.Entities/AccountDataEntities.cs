using TL.Engine.SDK.Extensions;

namespace TL.Account.Data.Entities
{
    public class AccountDataEntities : TLExtensionBase
    {
        public override string Name => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
    }
}
