using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;
using TL.Engine.SDK.Modularity.Items;
using TL.Engine.SDK.Services;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class ScriptsViewModelFactory
    {
        public ScriptsViewModel Create(IActivatorService activator)
        {
            List<ScriptItem> scripts = new List<ScriptItem>();

            foreach (var extensionMetadata in activator.GetInstances<BaseMetadataWeb>(useCaching: true))
            {
                scripts.AddRange(extensionMetadata.ScriptItems);
            }

            return new ScriptsViewModel()
            {
                Scripts = scripts
                    .OrderBy(s => s.Position)
                    .Select(s => new ScriptViewModelFactory().Create(s))
            };
        }
    }
}