using System.Collections.Generic;

namespace TL.Engine.SDK.Modularity.Items
{
    public class NotAvailableLinkItem : LinkItem
    {
        public NotAvailableLinkItem(string name, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null) : base(name, position, roles, items)
        {
        }

        public NotAvailableLinkItem(string url, string name, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null) : base(url, name, position, roles, items)
        {
        }

        public NotAvailableLinkItem(string url, string name, string description, int position, IEnumerable<string> roles = null, IEnumerable<LinkItem> items = null) : base(url, name, description, position, roles, items)
        {
        }

        public override bool IsAvailable => false;
    }
}
