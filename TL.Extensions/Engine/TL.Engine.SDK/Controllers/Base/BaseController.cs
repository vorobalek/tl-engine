using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.SDK.Controllers
{
    public abstract class BaseController : Controller, IBaseController
    {
        public IStorage Storage { get; }

        public BaseController(IStorage storage)
        {
            Storage = storage;
        }
    }
}
