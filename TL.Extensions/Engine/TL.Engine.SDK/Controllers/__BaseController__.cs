using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.SDK.Controllers
{
    public abstract class __BaseController__ : Controller
    {
        public IStorage Storage { get; }

        public __BaseController__(IStorage storage)
        {
            Storage = storage;
        }
    }
}
