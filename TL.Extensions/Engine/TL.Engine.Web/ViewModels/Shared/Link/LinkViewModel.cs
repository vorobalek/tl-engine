using System.Collections.Generic;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class LinkViewModel
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<LinkViewModel> Items { get; set; }
        public bool HasDescription => !string.IsNullOrWhiteSpace(Description);
    }
}