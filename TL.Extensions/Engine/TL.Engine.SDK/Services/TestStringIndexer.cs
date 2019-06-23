using System.Collections.Generic;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Engine.SDK.Services
{
    public class TestStringIndexer
    {
        IStringIndexerService StringIndexer { get; }

        public TestStringIndexer(IStringIndexerService stringIndexer)
        {
            StringIndexer = stringIndexer;
        }

        [PrivateApi]
        public string Add(string source)
        {
            StringIndexer.Add(source.ToLowerInvariant());
            return source;
        }

        [PublicApi]
        public IEnumerable<string> FindAll(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                query = "";
            }
            query = query.ToLowerInvariant();
            return StringIndexer.FindAll(query);
        }

        [PrivateApi]
        public void ResetStringIndexer()
        {
            StringIndexer.Reset();
        }
    }
}
