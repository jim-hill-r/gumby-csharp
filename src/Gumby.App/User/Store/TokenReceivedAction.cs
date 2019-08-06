using Blazor.Fluxor;

namespace Gumby.App.User.Store
{
    public class TokenReceivedAction
    {
        public string Token { get; }

        public TokenReceivedAction(string token)
        {
            Token = token;
        }
    }
}
