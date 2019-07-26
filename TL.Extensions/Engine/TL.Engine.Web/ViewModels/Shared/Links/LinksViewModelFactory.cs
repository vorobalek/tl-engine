using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;
using TL.Engine.SDK.Services;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class LinksViewModelFactory
    {
        public LinksViewModel Create(IActivatorService activator, IEnumerable<string> roles, string property)
        {
            return new LinksViewModel()
            {
                Items = activator
                    .GetInstances<BaseMetadataWeb>()
                    .SelectMany(it => it.GetType().GetProperty(property).GetValue(it) as IEnumerable<LinkItem>)
                    .GetValidLinkItems(roles)
                    .OrderBy(mi => mi.Position)
                    .Select(mi => new LinkViewModelFactory().Create(mi))
            };
        }
    }
}