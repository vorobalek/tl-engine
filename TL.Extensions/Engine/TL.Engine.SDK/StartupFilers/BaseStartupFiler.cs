using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using TL.Engine.SDK.Services;

namespace TL.Engine.SDK.StartupFilers
{
    public abstract class BaseStartupFiler : IStartupFilter
    {
        IStartupService StartupService { get; }

        public BaseStartupFiler(IStartupService startupService)
        {
            StartupService = startupService;
        }
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            if (StartupService.IsOk)
            {
                return Continue(next);
            }
            return SafeContinue(next);
        }

        protected abstract Action<IApplicationBuilder> Continue(Action<IApplicationBuilder> next);

        protected virtual Action<IApplicationBuilder> SafeContinue(Action<IApplicationBuilder> next)
        {
            return next;
        }
    }
}
