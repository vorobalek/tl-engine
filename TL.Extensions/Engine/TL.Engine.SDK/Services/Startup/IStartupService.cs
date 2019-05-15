using System;
using System.Collections.Generic;
using TL.Engine.SDK.Actions;

namespace TL.Engine.SDK.Services
{
    public interface IStartupService
    {
        string RedirectUrl { get; }
        List<IStartupActionResult> Log { get; }
        bool IsReady { get; }
        bool IsOk { get; }
    }
}