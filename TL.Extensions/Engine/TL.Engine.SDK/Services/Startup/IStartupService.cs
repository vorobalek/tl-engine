using System.Collections.Generic;
using TL.Engine.SDK.Actions;

namespace TL.Engine.SDK.Services
{
    public interface IStartupService
    {
        void Init();
        string RedirectUrl { get; }
        List<IStartupActionResult> Log { get; }
        bool IsReady { get; }
        bool IsOk { get; }
        double Progress { get; }
    }
}