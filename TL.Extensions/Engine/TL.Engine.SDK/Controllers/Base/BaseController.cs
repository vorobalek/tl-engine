using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.SDK.Controllers
{
    public abstract class BaseController : Controller, IBaseController
    {
        public BaseController()
        {
        }
    }
}
