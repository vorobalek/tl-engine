using System.Reflection;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.Data.Abstractions
{
    public class DataAbstractions : TLExtensionBase
    {
        public override string Name => Assembly.GetExecutingAssembly().GetName().Name;
    }
}
