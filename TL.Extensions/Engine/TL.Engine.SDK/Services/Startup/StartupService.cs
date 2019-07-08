using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
#if DEBUG
using System.Threading;
#endif
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.SDK.Services
{
    public class StartupService : IStartupService
    {
        private const string _defaultNextDescription = "Запуск...";
        public string NextDescription { get; private set; } = _defaultNextDescription;
        public bool SkipAll { get; set; } = false;
        public bool CanMoveNext { get; set; } = false;
        public bool IsDebugMode =>
#if DEBUG
            true;
#else
            false;
#endif
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
                .OrderBy(a => a.Priority)
                .ToArray();

            int number = 0, count = actions.Count();
            for (; number < count; )
            {
                var action = actions[number];
                NextDescription = number < count - 1 ? actions[number + 1].Description : _defaultNextDescription;
                Progress = number / (double)count * 100;
                IStartupActionResult actionResult;
                try
                {
                    Logger.TLogInformation($"{action.GetType().GetFullName()} running...");
                    Message = action.Description;
#if DEBUG
                    CanMoveNext = SkipAll;
                    while (!CanMoveNext && !SkipAll)
                    {
                        Thread.Sleep(1000);
                    }
#endif
                    actionResult = action.Invoke();
                    Logger.TLogInformation($"{action.GetType().GetFullName()} finished...");
                }
                catch (Exception ex)
                {
                    actionResult = StartupActionResult.Broken($"{ex}", action.Description);
                    Logger.TLogCritical($"{action.GetType().GetFullName()} broken...\r\n\t{ex}");
                }

                Log.Add(actionResult);

                ++number;
                Progress = number / (double)count * 100;

                if (!actionResult.IsFinal)
                {
                    break;
                }
            }

            IsOk = Log.All(e => e.IsFinal);
            IsReady = true;
        }

        public bool IsOk { get; private set; } = false;

        public string RedirectUrl => Log.LastOrDefault()?.RedurectUrl ?? "/runtime";

        public double Progress { get; private set; } = 0.0;

        public string Message { get; private set; }
    }
}
