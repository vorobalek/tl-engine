namespace TL.Account.Web.Areas.Account.ViewModels
{
    public class ProfileViewModel
    {
        public string Username { get; set; }

        public string Description { get; set; }

        public int SubscriptionsCount { get; set; }

        public int FollowersCount { get; set; }

        public bool IsSubscription { get; set; }

        public bool IsFollower { get; set; }
    }
}
