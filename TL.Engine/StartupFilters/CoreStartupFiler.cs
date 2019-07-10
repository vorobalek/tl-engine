using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Threading.Tasks;
using TL.Engine.SDK.Services;

namespace TL.Engine.StartupFilters
{
    internal class CoreStartupFilter : IStartupFilter
    {
        protected IStartupService StartupService { get; }

        public CoreStartupFilter(IStartupService startupService)
        {
            StartupService = startupService;
        }
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            if (!StartupService.IsReady)
            {
                Task.Run(() =>
                {
                    StartupService.Init();
                });
            }
            return next;
        }
    }
}
