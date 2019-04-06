using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TL.Account.Data.Abstractions.Relationships;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Extensions;
using TL.Account.Web.Areas.Account.ViewModels;
using TL.Engine.Data.Extensions;
using TL.Engine.Data.Managers;

using TlUser = TL.Engine.Data.Entities.Security.User;

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
                    var repository = Storage.GetRepository<ISubscriptionRepository>();
                    var item = repository.Get(e => e.FromId == user.Id && e.ToId == id);
                    if (item == null)
                    {
                        repository.Add(new Subscription()
                        {
                            FromId = user.Id,
                            ToId = id,
                        });
                        Storage.Save();
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
                    var item = repository.Get(e => e.FromId == user.Id && e.ToId == id);
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
