using TL.Engine.SDK.Controllers;

namespace TL.Api.SDK.Controllers
{
    public interface IBaseApiController : IBaseController
    {
        string Area { get; }

        string Command { get; }

        string Description { get; }
    }
}
