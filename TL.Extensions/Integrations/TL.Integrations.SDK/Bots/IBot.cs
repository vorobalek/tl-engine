using System.Threading.Tasks;
using TL.Integrations.SDK.Types.Messages;

namespace TL.Integrations.SDK.Bots
{
    public interface IBot
    {
        Task SendAsync(IMessage message);
    }
}
