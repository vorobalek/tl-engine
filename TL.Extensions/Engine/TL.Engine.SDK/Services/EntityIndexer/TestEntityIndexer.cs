using System.Collections.Generic;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Engine.SDK.Services
{
    public class TestEntityIndexer
    {
        IEntityIndexerService EntityIndexer { get; }

        public TestEntityIndexer(IEntityIndexerService entityIndexer)
        {
            EntityIndexer = entityIndexer;
        }

        [PrivateApi]
        public IEnumerable<object> FindAll(string query)
        {
            return EntityIndexer.Find(query);
        }

        [PrivateApi]
        public void ResetEntityIndexer()
        {
            EntityIndexer.Reset();
        }
    }
}
