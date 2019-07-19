using Gumby.User.Contract;

namespace Gumby.App.User.Store
{
    public class UserState
    {
        public bool IsAuthenticated { get; private set; }
        public UserData User { get; private set; }

        public string Token { get; private set; }

        public UserState()
        {
            IsAuthenticated = false;
        }

        public UserState(bool isAuthenticated, string token, UserData user)
        {
            IsAuthenticated = isAuthenticated;
            Token = token;
            User = user;
        }
    }
}
