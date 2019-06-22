using System.Collections.Generic;

namespace TL.Engine.SDK.Structures
{
    public class TrieNode : ITrieNode
    {
        public char? Symbol { get; }

        public bool IsTerminal { get; set; }

        public SortedList<char, ITrieNode> Next { get; }

        public void Put(string source)
        {
            var root = this as ITrieNode;
            for(int i = 0; i < source.Length; ++i)
            {
                var symbol = source[i];
                if (!root.Next.ContainsKey(symbol))
                {
                    root.Next.Add(symbol, new TrieNode(symbol));
                }
                root = root.Next[symbol];
            }
            root.IsTerminal = true;
        }

        public bool Contains(string source)
        {
            var root = this as ITrieNode;
            for (int i = 0; i < source.Length; ++i)
            {
                var symbol = source[i];
                if (!root.Next.ContainsKey(symbol))
                {
                    return false;
                }

                root = root.Next[symbol];
            }

            return root.IsTerminal;
        }

        public bool Find(string source)
        {
            var root = this as ITrieNode;
            for (int i = 0; i < source.Length; ++i)
            {
                var symbol = source[i];
                if (!root.Next.ContainsKey(symbol))
                {
                    foreach (var child in root.Next.Values)
                    {
                        if (child.Find(source)) return true;
                    }

                    return false;
                }

                root = root.Next[symbol];
            }

            return true;
        }

        public TrieNode(char? symbol = null, bool isTerminal = false)
        {
            Symbol = symbol;
            IsTerminal = isTerminal;
            Next = new SortedList<char, ITrieNode>();
        }
    }
}
