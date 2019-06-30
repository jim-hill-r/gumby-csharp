using Gumby.User.Contract;

namespace Gumby.App.User.Store
{
    public class UserState
    {
        public IUserData User { get; private set; }

        public UserState(IUserData user)
        {
            User = user;
        }
    }
}
