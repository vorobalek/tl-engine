using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Services;

namespace TL.Engine.SDK.Structures
{
    public class TrieApiProvider
    {
        IStringIndexerService StringIndexerService { get; }

        public TrieApiProvider(IStringIndexerService stringIndexerService)
        {
            StringIndexerService = stringIndexerService;
        }

        [PublicApi]
        public bool Add(string src)
        {
            return StringIndexerService.Add(src);
        }

        [PublicApi]
        public bool Find(string src)
        {
            return StringIndexerService.Find(src);
        }
    }
}
