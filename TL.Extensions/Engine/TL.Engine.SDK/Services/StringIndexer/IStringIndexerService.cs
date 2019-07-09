using System.Collections.Generic;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Интерфейс сервиса структуры данных бор.
    /// </summary>
    public interface IStringIndexerService
    {
        /// <summary>
        /// Добавить строку в бор.
        /// </summary>
        /// <param name="source">Строка.</param>
        [PrivateApi]
        void Add(string source);

        /// <summary>
        /// Выполнить поисковый запрос в боре.
        /// </summary>
        /// <param name="query">Строка запроса.</param>
        /// <returns></returns>
        [PrivateApi]
        IEnumerable<string> FindAll(string query);

        /// <summary>
        /// Сбросить структуру данных.
        /// </summary>
        [PrivateApi]
        void Reset();
    }
}