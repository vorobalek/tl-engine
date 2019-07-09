using System.Collections.Generic;

namespace TL.Engine.SDK.Structures
{
    /// <summary>
    /// Интерфейс ноды структуры данных БОР
    /// </summary>
    public interface ITrieNode
    {
        /// <summary>
        /// Символ текущей ноды.
        /// </summary>
        char? Symbol { get; }

        /// <summary>
        /// Признак конца "слова".
        /// </summary>
        bool IsTerminal { get; set; }

        /// <summary>
        /// Список смежных нод.
        /// </summary>
        SortedList<char, ITrieNode> Next { get; }

        /// <summary>
        /// Список целевых объектов текущей ноды.
        /// </summary>
        HashSet<object> Targets { get; }

        /// <summary>
        /// Добавить слово в поддерево текущей ноды.
        /// </summary>
        /// <param name="source">Слово.</param>
        /// <param name="target">Целевой объект.</param>
        void Add(string source, object target = null);

        /// <summary>
        /// Заменить слово на новое.
        /// </summary>
        /// <param name="oldSource">Старое слово.</param>
        /// <param name="newSource">Новое слово.</param>
        /// <param name="target">Целевой объект.</param>
        void Update(string oldSource, string newSource, object target = null);

        /// <summary>
        /// Удалить слово.
        /// </summary>
        /// <param name="source">Слово.</param>
        void Remove(string source);

        /// <summary>
        /// Найти все целевые объекты, привязанные к словам, содержащие запрос как подстроку.
        /// </summary>
        /// <param name="query">Строка-запрос.</param>
        /// <param name="count">Максимальное количсетво объектов в выборке. Если <c>0</c>, будут выбраны все результаты.</param>
        /// <returns></returns>
        IEnumerable<object> FindAll(string query, int count = 0);

        /// <summary>
        /// Добавить целевой объект к текущей ноде.
        /// </summary>
        /// <param name="target">Целевой объект.</param>
        void AddTarget(object target);
    }
}
