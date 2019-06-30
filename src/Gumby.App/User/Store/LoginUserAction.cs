using Blazor.Fluxor;

namespace Gumby.App.User.Store
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
