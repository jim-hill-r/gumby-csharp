using Gumby.Graph.Vertex.Common.User;

namespace Gumby.App.User.Store
{
    public class UserState
    {
        public bool IsAuthenticated { get; private set; }
        public UserChunk User { get; private set; }
        public string Token { get; private set; }

        public UserState()
        {
            IsAuthenticated = false;
        }

        public UserState(bool isAuthenticated, string token, UserChunk user)
        {
            IsAuthenticated = isAuthenticated;
            Token = token;
            User = user;
        }
    }
}
