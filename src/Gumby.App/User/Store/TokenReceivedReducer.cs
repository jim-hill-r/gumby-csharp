using System;
using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;
using Gumby.User.Contract;

namespace Gumby.App.User.Store
{
    public class TokenReceivedReducer : Reducer<UserState, TokenReceivedAction>
    {
        public override UserState Reduce(UserState state, TokenReceivedAction action)
        {
            return new UserState(true, action.Token, new UserData() { Id = Guid.NewGuid(), Username = "Logged in" });
        }
    }
}
