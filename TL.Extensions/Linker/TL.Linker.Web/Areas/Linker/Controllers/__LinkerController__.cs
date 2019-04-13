using ExtCore.Data.Abstractions;
using TL.Linker.SDK.Controllers;

namespace TL.Linker.Web.Areas.Linker.Controllers
{
    public abstract class __LinkerController__ : BaseLinkerController
    {
        public __LinkerController__(IStorage storage) : base(storage)
        {
        }
    }
}
