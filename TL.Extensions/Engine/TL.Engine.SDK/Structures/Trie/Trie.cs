namespace TL.Engine.SDK.Structures
{
    /// <summary>
    /// Дерево структуры данных БОР
    /// </summary>
    /// <seealso cref="TrieNode" />
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
