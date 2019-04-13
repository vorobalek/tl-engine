using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Linker.SDK.Controllers
{
    [Area("Linker")]
    public abstract class BaseLinkerController : BaseController
    {
        public BaseLinkerController(IStorage storage) : base(storage)
        {
        }
    }
}
