using System.Collections.Generic;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Engine.SDK.Services
{
    public class StringIndexerService : IStringIndexerService
    {
        IEntityIndexerService EntityIndexer { get; }

        public StringIndexerService(IEntityIndexerService entityIndexer)
        {
            EntityIndexer = entityIndexer;
        }

        [PublicApi]
        public IEnumerable<object> Find(string query)
        {
            return EntityIndexer.Find(query);
        }

        [PublicApi]
        public void Reset()
        {
            EntityIndexer.Reset();
        }
    }
}
