using System;

namespace TL.Engine.SDK.Actions
{
    /// <summary>
    /// Результат выполнения <see cref="IStartupAction"/>
    /// </summary>
    /// <seealso cref="TL.Engine.SDK.Actions.IStartupActionResult" />
    public class StartupActionResult : IStartupActionResult
    {
        /// <summary>
        /// <c>true</c>, если точка расширения смогла завершить работу, иначе <c>false</c>.
        /// </summary>
        public bool IsFinal { get; private set; }

        /// <summary>
        /// <c>true</c>, если точка разрешения корректно выполнила задачу.
        /// </summary>
        public bool Ok { get; private set; }

        /// <summary>
        /// Сообщение с результатом выполнения точки расширения.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Подробное объяснение результата выполнения точки расширения.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Время отрабатывания точки расширения.
        /// </summary>
        public DateTime Time { get; private set; }

        /// <summary>
        /// URL перенаправления при неудачном запуске на текущем этапе.
        /// </summary>
        public string RedurectUrl { get; private set; }

        public StartupActionResult()
        {
            Time = DateTime.Now.ToUniversalTime();
        }

        /// <summary>
        /// Положительный результат выполнения <see cref="IStartupAction"/>
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <param name="description">Описание.</param>
        /// <param name="redirectUrl">Url перенаправления запросов.</param>
        /// <returns></returns>
        public static StartupActionResult Good(string message = "Ok", string description = null, string redirectUrl = "/runtime") => new StartupActionResult()
        {
            IsFinal = true,
            Ok = true,
            Message = message,
            Description = description,
            RedurectUrl = redirectUrl,
        };

        /// <summary>
        /// Прерывающий результат выполнения <see cref="IStartupAction"/>
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <param name="description">Описание.</param>
        /// <param name="redirectUrl">Url перенаправления запросов.</param>
        /// <returns></returns>
        public static StartupActionResult Broken(string message, string description = null, string redirectUrl = "/runtime") => new StartupActionResult()
        {
            IsFinal = false,
            Ok = false,
            Message = message,
            Description = description,
            RedurectUrl = redirectUrl,
        };

        /// <summary>
        /// Отрицательный результат выполнения <see cref="IStartupAction"/>
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <param name="description">Описание.</param>
        /// <param name="redirectUrl">Url перенаправления запросов.</param>
        /// <returns></returns>
        public static StartupActionResult Bad(string message, string description = null, string redirectUrl = "/runtime") => new StartupActionResult()
        {
            IsFinal = true,
            Ok = false,
            Message = message,
            Description = description,
            RedurectUrl = redirectUrl,
        };
    }
}
