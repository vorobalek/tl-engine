using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TL.Account.Data.Extensions;
using TL.Account.Data.Managers;
using TL.Account.Web.Areas.Account.ViewModels;

namespace TL.Account.Web.Areas.Account.Controllers
{
    [Route("/account/profile")]
    public class ProfileController : __AccountController__
    {
        public ProfileController(IStorage storage, IUserManager userManager) : base(storage, userManager)
        {
        }

        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("index", "profile", new { username = User.Identity.Name });
        }

        [HttpGet("{username}")]
        public IActionResult Index(string username)
        {
            var user = username.GetUser(Storage);

            if (user == null)
            {
                return View(null);
            }

            var user_followers = user.GetFollowers(Storage);
            var user_subscriptions = user.GetSubscriptions(Storage);
            var requster = User?.GetUser(Storage);

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
