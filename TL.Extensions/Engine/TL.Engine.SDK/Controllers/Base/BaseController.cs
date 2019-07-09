using Microsoft.AspNetCore.Mvc;

namespace TL.Engine.SDK.Controllers
{
    /// <summary>
    /// Абстркатная реализация базового веб-контроллера.
    /// </summary>
    /// <seealso cref="Controller" />
    /// <seealso cref="IBaseController" />
    public abstract class BaseController : Controller, IBaseController
    {
        public BaseController()
        {
        }
    }
}
