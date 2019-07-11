using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Extensions;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Сервис первоначальной загрузки системы
    /// </summary>
    internal class StartupService : IStartupService
    {
        private const string _defaultNextDescription = "Запуск...";

        /// <summary>
        /// <see cref="IStartupAction.Description"/> следующего шага запуска.
        /// </summary>
        public string NextDescription { get; private set; } = _defaultNextDescription;

        /// <summary>
        /// Пропустить отладку и запустить в штатном режиме.
        /// </summary>
        public bool SkipAll { get; set; } = false;

        /// <summary>
        /// Можно переходить к следующему шагу запуска.
        /// </summary>
        public bool CanMoveNext { get; set; } = false;

        /// <summary>
        /// Запуск производится в режиме отладки.
        /// </summary>
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

        /// <summary>
        /// Система запущена.
        /// </summary>
        public bool IsReady { get; private set; } = false;

        /// <summary>
        /// Лог запуска.
        /// </summary>
        public List<IStartupActionResult> Log { get; private set; } = new List<IStartupActionResult>();

        /// <summary>
        /// Инициировать процесс запуска ядра.
        /// </summary>
        public void Init()
        {
            Log = new List<IStartupActionResult>();

            var actions = Activator.GetInstances<IStartupAction>()
                .OrderBy(a => a.Priority)
                .ToArray();

            int number = 0, count = actions.Count();
            for (; number < count; )
            {
                if (_duration > 0)
                {
                    Thread.Sleep(_duration);
                }
                var action = actions[number];
                NextDescription = number < count - 1 ? actions[number + 1].Description : _defaultNextDescription;
                Progress = number / (double)count * 100;
                IStartupActionResult actionResult;
                try
                {
#if DEBUG
                    CanMoveNext = SkipAll;
                    while (!CanMoveNext && !SkipAll)
                    {
                        Thread.Sleep(100);
                    }
#endif
                    Logger.TLogInformation($"{action.GetType().GetFullName()} running...");
                    Message = action.Description;
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

        private int _duration = 0;

        /// <summary>
        /// Задает длительность перехода между точками <see cref="IStartupAction"/> в мс.
        /// </summary>
        /// <param name="duration">Время в мс.</param>
        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        /// <summary>
        /// Запуск прошёл успешно.
        /// </summary>
        public bool IsOk { get; private set; } = false;

        /// <summary>
        /// Адрес переадресации запросов при запуске.
        /// </summary>
        public string RedirectUrl => Log.LastOrDefault()?.RedurectUrl ?? "/runtime";

        /// <summary>
        /// Прогрес запуска.
        /// </summary>
        public double Progress { get; private set; } = 0.0;

        /// <summary>
        /// Сообщение системы запуска на текущий момент.
        /// </summary>
        public string Message { get; private set; }
    }
}
