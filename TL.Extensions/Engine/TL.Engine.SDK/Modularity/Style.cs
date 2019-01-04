namespace TL.Engine.SDK.Modularity
{
    public class Style
    {
        public string Url { get; set; }

        public int Position { get; set; }

        public Style(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}
