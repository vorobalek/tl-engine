namespace TL.Engine.SDK.Modularity.Items
{
    public class StyleItem
    {
        public string Url { get; set; }

        public int Position { get; set; }

        public StyleItem(string url, int position)
        {
            Url = url;
            Position = position;
        }
    }
}
