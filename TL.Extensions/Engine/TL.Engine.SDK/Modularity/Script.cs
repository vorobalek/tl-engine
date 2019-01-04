namespace TL.Engine.SDK.Modularity
{
    public class Script
    {
        public string Url { get; set; }

        public int Position { get; set; }

        public Script(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}
