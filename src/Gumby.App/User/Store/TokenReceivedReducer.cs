using Blazor.Fluxor;
using Gumby.App.User.Models;
using System;

namespace Gumby.App.User.Store
{
    public class TokenReceivedReducer : Reducer<UserState, TokenReceivedAction>
    {
        public override UserState Reduce(UserState state, TokenReceivedAction action)
        {
            return new UserState(true, action.Token, new UserFull() { Id = Guid.NewGuid(), Name = "Logged in" });
        }
    }
}
