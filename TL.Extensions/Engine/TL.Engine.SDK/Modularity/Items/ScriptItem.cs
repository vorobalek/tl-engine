namespace TL.Engine.SDK.Modularity.Items
{
    public class ScriptItem
    {
        public string Url { get; set; }

        public int Position { get; set; }

        public ScriptItem(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}
