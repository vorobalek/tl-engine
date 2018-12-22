using System.Reflection;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.Data.EntityFramework
{
    public class DataEntityFramework : TLExtensionBase
    {
        public override string Name => Assembly.GetExecutingAssembly().GetName().Name;
    }
}
