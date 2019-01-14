namespace TL.Engine.SDK.Controllers
{
    public interface IBaseApiController : IBaseController
    {
        string Area { get; }

        string Command { get; }

        string Description { get; }
    }
}
