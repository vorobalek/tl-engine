using System.Collections.Generic;

namespace TL.Engine.SDK.Modularity.Items
{
    public class LinkItem
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public IEnumerable<LinkItem> Items { get; set; }
        public int Position { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public LinkItem(string url, string name, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null)
        {
            Url = url;
            Name = name;
            Position = position;
            Roles = roles;
            Items = items;
        }
    }
}
