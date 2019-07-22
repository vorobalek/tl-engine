using System.Collections.Generic;
using TL.Engine.SDK.Actions;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Интерфейс сервиса первоначальной загрузки системы
    /// </summary>
    public interface IStartupService
    {
        /// <summary>
        /// Пропустить отладку и запустить в штатном режиме.
        /// </summary>
        bool SkipAll { get; set; }

        /// <summary>
        /// Можно переходить к следующему шагу запуска.
        /// </summary>
        bool CanMoveNext { get; set; }

        /// <summary>
        /// Запуск производится в режиме отладки.
        /// </summary>
        bool IsDebugMode { get; }

        /// <summary>
        /// <see cref="IStartupAction.Description"/> следующего шага запуска.
        /// </summary>
        string NextDescription { get; }

        /// <summary>
        /// Инициировать процесс запуска ядра.
        /// </summary>
        void Init();

        /// <summary>
        /// Адрес переадресации запросов при запуске.
        /// </summary>
        string RedirectUrl { get; }

        /// <summary>
        /// Лог запуска.
        /// </summary>
        List<IStartupActionResult> Log { get; }

        /// <summary>
        /// Система запущена.
        /// </summary>
        bool IsReady { get; }

        /// <summary>
        /// Запуск прошёл успешно.
        /// </summary>
        bool IsOk { get; }

        /// <summary>
        /// Прогрес запуска.
        /// </summary>
        double Progress { get; }

        /// <summary>
        /// Сообщение системы запуска на текущий момент.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Cообщение от активной на данный момент контрольной точки системы запуска.
        /// </summary>
        string CallbackMessage { get; }

        /// <summary>
        /// Метод обратного вызова от контролькой точки, к системе запуска.
        /// </summary>
        /// <param name="message">Устанавливает <see cref="CallbackMessage"/>.</param>
        /// <param name="progress">Устанавливает <see cref="Progress"/> в диапазоне от 0 до 100, где 0 - начало текущей контрольной точки, а 100 - начало следующей.</param>
        void InvokeCallback(string message, double progress);

        /// <summary>
        /// Задает длительность перехода между точками <see cref="IStartupAction"/> в мс.
        /// </summary>
        /// <param name="duration">Время в мс.</param>
        void SetDuration(int duration);
    }
}