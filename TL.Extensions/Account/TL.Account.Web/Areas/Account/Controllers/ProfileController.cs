using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Web.Areas.Account.ViewModels;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Route("/Account/Profile")]
    public class ProfileController : __AccountController__
    {
        public ProfileController(IStorage storage) : base(storage)
        {
        }

        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Profile", new { username = User.Identity.Name });
        }

        [HttpGet("{username}")]
        public IActionResult Index(string username)
        {
            var user = Storage.GetRepository<IUserRepository>().GetByUsername(username);

            if (user == null)
            {
                return View(null);
            }

            var user_followers = Storage.GetRepository<ISubscriptionRepository>().Followers(user);
            var user_subscriptions = Storage.GetRepository<ISubscriptionRepository>().Subscriptions(user);
            var requster = Storage.GetRepository<IUserRepository>().GetByUsername(User.Identity.Name);

            bool isF = false,
                isS = false;

            if (requster != null)
            {
                isF = user_subscriptions.Contains(requster.Id);
                isS = user_followers.Contains(requster.Id);
            }

            return View(new ProfileViewModel()
            {
                Username = user.Username,
                Description = user.Description,
                FollowersCount = user_followers.Count(),
                SubscriptionsCount = user_subscriptions.Count(),
                IsFollower = isF,
                IsSubscription = isS
            });
        }
    }
}
