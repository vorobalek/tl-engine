using ExtCore.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class ScriptsViewModelFactory
    {
        public ScriptsViewModel Create()
        {
            List<Script> scripts = new List<Script>();

            foreach (var extensionMetadata in ExtensionManager.GetInstances<MetadataBaseWeb>())
            {
                scripts.AddRange(extensionMetadata.Scripts);
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