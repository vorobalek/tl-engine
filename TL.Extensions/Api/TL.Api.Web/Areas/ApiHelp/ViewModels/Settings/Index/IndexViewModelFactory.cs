using System.Linq;
using TL.Account.Data.Managers;
using TL.Api.Data.Managers;

namespace TL.Api.Web.Areas.ApiHelp.ViewModels.Settings
{
    public class IndexViewModelFactory
    {
        public IndexViewModel Create(IUserManager userManager, ITokenManager tokenManager)
        {
            var tokens = tokenManager.GetAll(true).ToArray();
            for (int i = 0; i < tokens.Length; ++i)
            {
                if (tokens[i].OwnerId.HasValue)
                {
                    tokens[i].Owner = userManager.Get(tokens[i].OwnerId.Value, true);
                }
            }

            return new IndexViewModel()
            {
                Tokens = tokens,
            };
        }
    }
}