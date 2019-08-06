using Blazor.Fluxor;
using Gumby.Graph.Vertex.Common.User;
using System;

namespace Gumby.App.User.Store
{
    public class TokenReceivedReducer : Reducer<UserState, TokenReceivedAction>
    {
        public override UserState Reduce(UserState state, TokenReceivedAction action)
        {
            return new UserState(true, action.Token, new UserChunk() { Id = Guid.NewGuid(), Name = "Logged in" });
        }
    }
}
