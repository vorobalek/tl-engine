using System.Threading.Tasks;
using TL.Integrations.SDK.Messages;

namespace TL.Integrations.SDK.Bots
{
    public interface IBot
    {


        Task SendAsync(IMessage message);
    }
}
