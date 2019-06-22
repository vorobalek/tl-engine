using System.Collections.Generic;

namespace TL.Engine.SDK.Services
{
    public interface IStringIndexerService
    {
        IEnumerable<object> Find(string query);
        void Reset();
    }
}