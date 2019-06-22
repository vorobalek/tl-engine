using System;
using System.Collections.Generic;

namespace TL.Engine.SDK.Structures
{
    public class TrieNode : ITrieNode
    {
        public char? Symbol { get; }

        public bool IsTerminal { get; set; }

        public SortedList<char, ITrieNode> Next { get; }

        public HashSet<object> Targets { get; }

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

        public void Update(string oldSource, string newSource, object target = null)
        {
            Remove(oldSource);
            Add(newSource, target);
        }

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

        public void AddTarget(object target)
        {
            if (target != null)
            {
                Targets.Add(target);
            }
        }
    }
}
