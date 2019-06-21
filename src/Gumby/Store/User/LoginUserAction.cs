using Blazor.Fluxor;

namespace Gumby.Store.User
{
    public class LoginUserAction : IAction
    {
        public string Username { get; }

        public LoginUserAction(string username)
        {
            Username = username;
        }
    }
}
