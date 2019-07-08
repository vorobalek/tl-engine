using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Modularity.Items
{
    public class LinkItem
    {
        private string _url;

        public string Url
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_url)) return _url;

                var item = Items.FirstOrDefault(i => i.Url != "#");
                if (item != null) return item.Url;

                return "#";
            }

            set => _url = value;
        }
        public string Name { get; set; }
        public IEnumerable<LinkItem> Items { get; set; }
        public int Position { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public LinkItem(string url, string name, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null)
            : this(url, name, null, position, roles, items)
        {
        }

        public LinkItem(string name, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null)
            : this(null, name, position, roles, items)
        {
        }

        public LinkItem(string url, string name, string description, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null)
        {
            Url = url;
            Name = name;
            Description = description;
            Position = position;
            Roles = roles;
            Items = items;
        }
    }
}
