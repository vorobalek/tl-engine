namespace TL.Engine.SDK.Modularity
{
    public class NavItem
    {
        public string Url { get; set; }
        public string Name { get; }
        public int Position { get; }

        public NavItem(string url, string name, int position)
        {
            Url = url;
            Name = name;
            Position = position;
        }
    }
}
