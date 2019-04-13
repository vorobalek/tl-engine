using TL.Engine.SDK.Managers;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.Managers
{
    public interface ILinkManager : IEntityComparableStoredManager<Link, int>
    {
        string GetLinkUrl(string url);
        Link Create(string url);
        string LinkConvert(int number);
        int LinkParse(string code);
    }
}
