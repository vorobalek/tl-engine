namespace TL.Engine.SDK.Structures
{
    public class Trie : TrieNode
    {
        public Trie(char? symbol = null, object target = null, bool isTerminal = false) : base(symbol, target, isTerminal)
        {
        }

        public static Trie Create()
        {
            return new Trie();
        }
    }
}
