using Gumby.App.User.Models;

namespace Gumby.App.User.Store
{
    public class UserState
    {
        public bool IsAuthenticated { get; private set; }
        public UserInfo User { get; private set; }
        public string Token { get; private set; }

        public UserState()
        {
            IsAuthenticated = false;
        }

        public UserState(bool isAuthenticated, string token, UserInfo user)
        {
            IsAuthenticated = isAuthenticated;
            Token = token;
            User = user;
        }
    }
}
