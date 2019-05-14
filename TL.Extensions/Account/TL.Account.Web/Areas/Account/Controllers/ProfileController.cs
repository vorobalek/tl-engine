using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
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
                var user = UserManager.Get(userId);
                if (user != null)
                {
                    var item = SubscriptionManager.Get(e => e.FromId == user.Id && e.ToId == id);
                    if (item == null)
                    {
                        var subsription = SubscriptionManager.CreateEmpty();
                        subsription.From = user;
                        subsription.ToId = id;
                        SubscriptionManager.Update(subsription);

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
            return PartialView("_StatusMessage", message);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Unsubscribe(Guid id)
        {
            string message = "";
            if (Guid.TryParse(User.Claims.FirstOrDefault(e => e.Type == nameof(TlUser.Id))?.Value ?? "", out Guid userId))
            {
                var user = UserManager.Get(userId);
                if (user != null)
                {
                    var repository = Storage.GetRepository<ISubscriptionRepository>();

                    var item = SubscriptionManager.Get(e => e.FromId == user.Id && e.ToId == id);
                    if (item != null)
                    {
                        repository.Remove(item);
                        Storage.Save();
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
            return PartialView("_StatusMessage", message);
        }

        [HttpGet("[area]/[controller]/{username}")]
        public IActionResult Index(string username)
        {
            var user = UserManager.Get(username);

            if (user == null)
            {
                return View(null);
            }

            var user_followers = user.GetFollowersUids(Storage);
            var user_subscriptions = user.GetSubscriptionsUids(Storage);
            var requester = UserManager.GetByClaims(User);

            bool isF = false,
                isS = false;

            if (requester != null)
            {
                isF = user_subscriptions.Contains(requester.Id);
                isS = user_followers.Contains(requester.Id);
            }

            return View(new ProfileViewModel()
            {
                Id = user.Id,
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
