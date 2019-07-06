using System.Collections.Generic;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Engine.SDK.Services
{
    public interface IStringIndexerService
    {
        [PrivateApi]
        void Add(string source);

        [PrivateApi]
        IEnumerable<string> FindAll(string query);

        [PrivateApi]
        void Reset();
    }
}