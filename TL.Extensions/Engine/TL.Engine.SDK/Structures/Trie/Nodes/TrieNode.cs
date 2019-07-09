using System;
using System.Collections.Generic;

namespace TL.Engine.SDK.Structures
{
    /// <summary>
    /// Реализация ноды структуры данных БОР
    /// </summary>
    public class TrieNode : ITrieNode
    {
        /// <summary>
        /// Символ текущей ноды.
        /// </summary>
        public char? Symbol { get; }

        /// <summary>
        /// Признак конца "слова".
        /// </summary>
        public bool IsTerminal { get; set; }

        /// <summary>
        /// Список смежных нод.
        /// </summary>
        public SortedList<char, ITrieNode> Next { get; }

        /// <summary>
        /// Список целевых объектов текущей ноды.
        /// </summary>
        public HashSet<object> Targets { get; }

        /// <summary>
        /// Добавить слово в поддерево текущей ноды.
        /// </summary>
        /// <param name="source">Слово.</param>
        /// <param name="target">Целевой объект.</param>
        public void Add(string source, object target = null)
        {
            var root = this as ITrieNode;
            root.AddTarget(target);
            for (int i = 0; i < source.Length; ++i)
            {
                var symbol = source[i];
                if (!root.Next.ContainsKey(symbol))
                {
                    root.Next.Add(symbol, new TrieNode(symbol, target));
                }
                root = root.Next[symbol];
                root.AddTarget(target);
            }
            root.IsTerminal = true;
        }

        /// <summary>
        /// Заменить слово на новое.
        /// </summary>
        /// <param name="oldSource">Старое слово.</param>
        /// <param name="newSource">Новое слово.</param>
        /// <param name="target">Целевой объект.</param>
        public void Update(string oldSource, string newSource, object target = null)
        {
            Remove(oldSource);
            Add(newSource, target);
        }

        /// <summary>
        /// Удалить слово.
        /// </summary>
        /// <param name="source">Слово.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Remove(string source)
        {
            var root = this as ITrieNode;
            Stack<ITrieNode> history = new Stack<ITrieNode>(new[] { root });

            int i = 0;
            for (; i < source.Length && root.Next.ContainsKey(source[i]); ++i)
            {
                root = root.Next[source[i]];
                history.Push(root);
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Найти все целевые объекты, привязанные к словам, содержащие запрос как подстроку.
        /// </summary>
        /// <param name="query">Строка-запрос.</param>
        /// <param name="count">Максимальное количсетво объектов в выборке. Если <c>0</c>, будут выбраны все результаты.</param>
        /// <returns></returns>
        public IEnumerable<object> FindAll(string query, int count = 0)
        {
            query = query ?? "";
            var result = new HashSet<object>();
            var root = this as ITrieNode;

            int i = 0;
            for (; i < query.Length && root.Next.ContainsKey(query[i]); ++i)
            {
                root = root.Next[query[i]];
            }
            if (i == query.Length)
            {
                result.UnionWith(root.Targets);
            }

            root = this as ITrieNode;
            foreach (var child in root.Next.Values)
            {
                var childResult = child.FindAll(query, count);
                result.UnionWith(childResult);    
            }

            return result;
        }

        public TrieNode(char? symbol = null, object target = null, bool isTerminal = false)
        {
            Symbol = symbol;
            IsTerminal = isTerminal;
            Next = new SortedList<char, ITrieNode>();
            Targets = new HashSet<object>();

            AddTarget(target);
        }

        /// <summary>
        /// Добавить целевой объект к текущей ноде.
        /// </summary>
        /// <param name="target">Целевой объект.</param>
        public void AddTarget(object target)
        {
            if (target != null)
            {
                Targets.Add(target);
            }
        }
    }
}
