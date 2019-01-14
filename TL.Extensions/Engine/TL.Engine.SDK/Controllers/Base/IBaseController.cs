using ExtCore.Data.Abstractions;

namespace TL.Engine.SDK.Controllers
{
    public interface IBaseController
    {
        IStorage Storage { get; }
    }
}
