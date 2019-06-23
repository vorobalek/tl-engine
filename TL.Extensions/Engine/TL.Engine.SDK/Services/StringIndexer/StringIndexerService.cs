using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Structures;

namespace TL.Engine.SDK.Services
{
    public class StringIndexerService : IStringIndexerService
    {
        Trie Trie { get; set; }

        public StringIndexerService()
        {
            Trie = Trie.Create();
        }

        public void Add(string source)
        {
            Trie.Add(source, source);
        }

        public IEnumerable<string> FindAll(string query)
        {
            return Trie.FindAll(query).Select(obj => obj as string);
        }

        public void Reset()
        {
            Trie = Trie.Create();
        }
    }
}
