using System.Collections.Generic;

namespace TL.Engine.SDK.Structures
{
    public interface ITrieNode
    {
        char? Symbol { get; }
        bool IsTerminal { get; set; }
        SortedList<char, ITrieNode> Next { get; }
        HashSet<object> Targets { get; }

        void Put(string source, object target = null);
        IEnumerable<object> FindAll(string query, int count = 0);
        void AddTarget(object target);
    }
}
