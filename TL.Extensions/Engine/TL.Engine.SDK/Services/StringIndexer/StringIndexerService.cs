using TL.Engine.SDK.Structures;

namespace TL.Engine.SDK.Services
{
    public class StringIndexerService : IStringIndexerService
    {
        private Trie Trie { get; }

        public StringIndexerService()
        {
            Trie = Trie.Create();
        }

        public bool Add(string source)
        {
            Trie.Put(source);
            return true;
        }

        public bool Find(string source)
        {
            return Trie.Find(source);
        }
    }
}
