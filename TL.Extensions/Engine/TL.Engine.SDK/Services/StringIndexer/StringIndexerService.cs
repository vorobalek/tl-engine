using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Structures;

namespace TL.Engine.SDK.Services
{
    /// <summary>
    /// Сервис структуры данных бор.
    /// </summary>
    internal class StringIndexerService : IStringIndexerService
    {
        /// <summary>
        /// Ссылка на главную ноду.
        /// </summary>
        Trie Trie { get; set; }

        public StringIndexerService()
        {
            Trie = Trie.Create();
        }

        /// <summary>
        /// Добавить строку в бор.
        /// </summary>
        /// <param name="source">Строка.</param>
        public void Add(string source)
        {
            Trie.Add(source, source);
        }

        /// <summary>
        /// Выполнить поисковый запрос в боре.
        /// </summary>
        /// <param name="query">Строка запроса.</param>
        /// <returns></returns>
        public IEnumerable<string> FindAll(string query)
        {
            return Trie.FindAll(query).Select(obj => obj as string);
        }

        /// <summary>
        /// Сбросить структуру данных.
        /// </summary>
        public void Reset()
        {
            Trie = Trie.Create();
        }
    }
}
