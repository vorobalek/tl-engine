using System.Collections.Generic;

namespace TL.Engine.SDK.Structures
{
    public interface ITrieNode
    {
        char? Symbol { get; }
        bool IsTerminal { get; set; }
        SortedList<char, ITrieNode> Next { get; }

        void Put(string source);
        bool Contains(string source);
        bool Find(string source);
    }
}
