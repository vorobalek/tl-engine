using System.Collections.Generic;

namespace TL.Engine.SDK.Services
{
    public interface IStringIndexerService
    {
        void Add(string source);
        IEnumerable<string> FindAll(string query);
        void Reset();
    }
}