using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Extensions;
using TL.Account.Data.Managers;
using TL.Account.Web.Areas.Account.ViewModels;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;

using TlUser = TL.Engine.Data.Entities.Security.User;

namespace TL.Account.Web.Areas.Account.Controllers
{
    public class ProfileController : __AccountController__
    {
        ISubscriptionManager SubscriptionManager { get; }

        IStorage Storage { get; }

        public ProfileController(IStorage storage, ISubscriptionManager subscriptionManager, IUserManager userManager) : base(userManager)
        {
            Storage = storage;
            SubscriptionManager = subscriptionManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            return Index(User.Identity.Name);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Subscribe(Guid id)
        {
            string message = "";
            if (Guid.TryParse(User.Claims.FirstOrDefault(e => e.Type == nameof(TlUser.Id))?.Value ?? "", out Guid userId))
            {
                var user = UserManager.GetByKey(userId);
                if (user != null)
                {
                    var item = SubscriptionManager.Get(e => e.FromId == user.Id && e.ToId == id);
                    if (item == null)
                    {
                        var subscription = SubscriptionManager.CreateEmpty(cacheOnly: true);
                        subscription.FromId = user.Id;
                        subscription.ToId = id;
                        SubscriptionManager.Create(subscription);

                        message = $"Вы успешно подписались на этого пользователя";
                    }
                    else
                    {
                        message = $"Подписка была оформлена ранее";
                    }
                }
                else
                {
                    message = $"Вашей учетной записи не существует";
                }
            }
            return PartialView($"_StatusMessage", message);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Unsubscribe(Guid id)
        {
            string message = "";
            if (Guid.TryParse(User.Claims.FirstOrDefault(e => e.Type == nameof(TlUser.Id))?.Value ?? "", out Guid userId))
            {
                var user = UserManager.GetByKey(userId);
                if (user != null)
                {
                    var item = SubscriptionManager.Get(e => e.FromId == user.Id && e.ToId == id);
                    if (item != null)
                    {
                        SubscriptionManager.Remove(item);
                        message = $"Вы успешно отписались от этого пользователя";
                    }
                    else
                    {
                        message = $"Подписка была отменена ранее";
                    }
                }
                else
                {
                    message = $"Вашей учетной записи не существует";
                }
            }
            return PartialView($"_StatusMessage", message);
        }

        [HttpGet("[area]/[controller]/{username}")]
        public IActionResult Index(string username)
        {
            var user = UserManager.Get(username);

            if (user == null)
            {
                return View(null);
            }

            var userFollowers = user.GetFollowersUids(Storage);
            var userSubscriptions = user.GetSubscriptionsUids(Storage);
            var requester = UserManager.GetByClaims(User);

            bool isF = false,
                isS = false;

            var userSubscriptionsList = userSubscriptions.ToList();
            var userFollowersList = userFollowers.ToList();
            if (requester != null)
            {
                isF = userSubscriptionsList.Contains(requester.Id);
                isS = userFollowersList.Contains(requester.Id);
            }

            return View(new ProfileViewModel()
            {
                Id = user.Id,
                Username = user.Username,
                Description = user.Description,
                FollowersCount = userFollowersList.Count(),
                SubscriptionsCount = userSubscriptionsList.Count(),
                IsFollower = isF,
                IsSubscription = isS
            });
        }
    }
}
