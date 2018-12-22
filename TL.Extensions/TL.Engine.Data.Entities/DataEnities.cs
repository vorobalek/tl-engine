using System.Reflection;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.Data.Entities
{
    public class DataEnities : TLExtensionBase
    {
        public override string Name => Assembly.GetExecutingAssembly().GetName().Name;
    }
}
