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
            Init();
        }

        public bool IsReady { get; private set; } = false;

        private List<IStartupActionResult> _checkLog = new List<IStartupActionResult>();

        public List<IStartupActionResult> Log
        {
            get
            {
                if (IsReady)
                {
                    return _checkLog;
                }
                else
                {
                    Init();
                    return _checkLog;
                }
            }
        }

        private void Init()
        {
            _checkLog = new List<IStartupActionResult>();

            var actions = Activator.GetInstances<IStartupAction>()
                .OrderBy(a => a.Priority);

            foreach (var action in actions)
            {
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

                _checkLog.Add(actionResult);
                if (!actionResult.Ok && action.IsBlocker)
                {
                    break;
                }
            }

            IsReady = true;
        }

        public bool IsOk => Log.All(e => e.Ok);

        public string RedirectUrl => Log.LastOrDefault()?.RedurectUrl ?? "/";
    }
}
