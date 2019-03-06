using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using TL.Engine.SDK.Controllers;

namespace TL.Api.SDK.Controllers
{
    [Area("ApiHelp")]
    public abstract class BaseApiHelpController : BaseController
    {
        public BaseApiHelpController(IStorage storage) : base(storage)
        {
        }
    }
}
