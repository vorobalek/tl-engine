using System.Collections.Generic;

namespace TL.Engine.SDK.Modularity
{
    public class NavItem
    {
        public string Url { get; set; }
        public string Name { get; }
        public int Position { get; }
        public IEnumerable<string> Roles { get; }

        public NavItem(string url, string name, int position, IEnumerable<string> roles = null)
        {
            Url = url;
            Name = name;
            Position = position;
            Roles = roles;
        }
    }
}
