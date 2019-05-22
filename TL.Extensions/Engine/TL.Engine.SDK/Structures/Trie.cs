namespace TL.Engine.SDK.Structures
{
    public class Trie : TrieNode
    {
        public Trie(char? symbol = null, bool isTerminal = false) : base(symbol, isTerminal)
        {
        }

        public static Trie Create()
        {
            return new Trie();
        }
    }
}
