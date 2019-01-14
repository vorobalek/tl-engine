using TL.Engine.SDK.Modularity.Items;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class ScriptViewModelFactory
    {
        public ScriptViewModel Create(ScriptItem script)
        {
            return new ScriptViewModel()
            {
                Url = script.Url
            };
        }
    }
}