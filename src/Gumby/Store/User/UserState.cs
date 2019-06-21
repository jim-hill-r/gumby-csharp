using Gumby.Contract.User;

namespace Gumby.Store.User
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
