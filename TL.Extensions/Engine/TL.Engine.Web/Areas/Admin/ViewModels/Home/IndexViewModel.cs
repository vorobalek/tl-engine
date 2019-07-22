using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;
using TL.Engine.Web.ViewModels.Shared;

namespace TL.Engine.Web.Areas.Admin.ViewModels.Home
{
    public class IndexViewModel
    {
        public IDictionary<string, List<LinkViewModel>> Sections { get; }

        public IndexViewModel()
        {
            Sections = new Dictionary<string, List<LinkViewModel>>();
            var modules = ExtensionManager.GetInstances<BaseMetadataWeb>();
            foreach (var module in modules)
            {
                var items = module.GetAdminItems()?
                        .Select(it => new LinkViewModelFactory().Create(it))
                        .ToList() ?? new List<LinkViewModel>();
                if (!Sections.ContainsKey(module.Owner))
                {
                    Sections.Add(module.Owner, items);
                }
                else
                {
                    Sections[module.Owner].AddRange(items);
                }
            }
        }
    }
}
