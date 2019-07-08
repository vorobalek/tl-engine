using System.Collections.Generic;
using TL.Engine.SDK.Actions;

namespace TL.Engine.SDK.Services
{
    public interface IStartupService
    {
        bool SkipAll { get; set; }
        bool CanMoveNext { get; set; }
        bool IsDebugMode { get; }

        string NextDescription { get; }

        void Init();
        string RedirectUrl { get; }
        List<IStartupActionResult> Log { get; }
        bool IsReady { get; }
        bool IsOk { get; }
        double Progress { get; }
        string Message { get; }
    }
}