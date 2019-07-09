namespace TL.Engine.SDK.Actions
{
    /// <summary>
    /// Интерфейс действия перед запуском системы. 
    /// </summary>
    public interface IStartupAction
    {
        /// <summary>
        /// Приоритет выполнения точки расширения.
        /// </summary>
        int Priority { get; }

        /// <summary>
        /// Описание точки расширения.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Метод точки расширения.
        /// </summary>
        /// <returns></returns>
        IStartupActionResult Invoke();
    }
}
