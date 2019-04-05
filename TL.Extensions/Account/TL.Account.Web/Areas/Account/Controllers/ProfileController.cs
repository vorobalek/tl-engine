using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TL.Account.Data.Extensions;
using TL.Account.Web.Areas.Account.ViewModels;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public class ProfileController : __AccountController__
    {
        public ProfileController(IStorage storage, IUserManager userManager) : base(storage, userManager)
        {
        }

        [Authorize]
        public IActionResult Index()
        {
            return Index(User.Identity.Name);
        }

        [HttpGet("[area]/[controller]/{username}")]
        public IActionResult Index(string username)
        {
            var user = username.GetUser(Storage);

            if (user == null)
            {
                return View(null);
            }

            var user_followers = user.GetFollowersUids(Storage);
            var user_subscriptions = user.GetSubscriptionsUids(Storage);
            var requester = User?.GetUser(Storage);

            bool isF = false,
                isS = false;

            if (requester != null)
            {
                isF = user_subscriptions.Contains(requester.Id);
                isS = user_followers.Contains(requester.Id);
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
