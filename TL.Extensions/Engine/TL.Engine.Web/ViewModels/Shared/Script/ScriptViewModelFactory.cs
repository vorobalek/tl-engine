using TL.Engine.SDK.Modularity;

namespace TL.Engine.Web.ViewModels.Shared
{
    public class ScriptViewModelFactory
    {
        public ScriptViewModel Create(Script script)
        {
            return new ScriptViewModel()
            {
                Url = script.Url
            };
        }
    }
}