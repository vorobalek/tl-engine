using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.SDK.Services
{
    public class StartupService : IStartupService
    {
        ILogger Logger { get; }

        IActivatorService Activator { get; }

        public StartupService(ILoggerFactory loggerFactory, IActivatorService activator)
        {
            Logger = loggerFactory.CreateLogger<StartupService>();
            Activator = activator;
        }

        public bool IsReady { get; private set; } = false;

        public List<IStartupActionResult> Log { get; private set; } = new List<IStartupActionResult>();

        public void Init()
        {
            Log = new List<IStartupActionResult>();

            var actions = Activator.GetInstances<IStartupAction>()
                .OrderBy(a => a.Priority);

            int number = 0, count = actions.Count();
            foreach (var action in actions)
            {
                Progress = number / (double)count * 100;
                IStartupActionResult actionResult;
                try
                {
                    Logger.TLogInformation($"{action.GetType().GetFullName()} running...");
                    actionResult = action.Invoke();
                    Logger.TLogInformation($"{action.GetType().GetFullName()} finished...");
                }
                catch (Exception ex)
                {
                    actionResult = StartupActionResult.Broken($"{ex}");
                    Logger.TLogCritical($"{action.GetType().GetFullName()} broken...\r\n\t{ex}");
                }

                Log.Add(actionResult);

                ++number;
                Progress = number / (double)count * 100;

                if (!actionResult.Ok && action.IsBlocker)
                {
                    break;
                }
            }

            IsOk = Log.All(e => e.Ok);
            IsReady = true;
        }

        public bool IsOk { get; private set; } = false;

        public string RedirectUrl => Log.LastOrDefault()?.RedurectUrl ?? "/";

        public double Progress { get; private set; } = 0.0;
    }
}
