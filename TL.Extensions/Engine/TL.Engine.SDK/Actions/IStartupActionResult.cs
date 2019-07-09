using System;

namespace TL.Engine.SDK.Actions
{
    /// <summary>
    /// Интерфейс результата выполнения <see cref="IStartupAction"/>
    /// </summary>
    public interface IStartupActionResult
    {
        /// <summary>
        /// URL перенаправления при неудачном запуске на текущем этапе.
        /// </summary>
        string RedurectUrl { get; }

        /// <summary>
        /// Время отрабатывания точки расширения.
        /// </summary>
        DateTime Time { get; }

        /// <summary>
        /// <c>true</c>, если точка расширения смогла завершить работу, иначе <c>false</c>.
        /// </summary>
        bool IsFinal { get; }

        /// <summary>
        /// <c>true</c>, если точка разрешения корректно выполнила задачу.
        /// </summary>
        bool Ok { get; }

        /// <summary>
        /// Сообщение с результатом выполнения точки расширения.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Подробное объяснение результата выполнения точки расширения.
        /// </summary>
        string Description { get; }
    }
}