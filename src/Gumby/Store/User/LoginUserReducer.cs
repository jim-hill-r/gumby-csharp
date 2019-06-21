using Blazor.Fluxor;
using Gumby.Model.User;
using System;

namespace Gumby.Store.User
{
    public class LoginUserReducer : Reducer<UserState, LoginUserAction>
    {
        public override UserState Reduce(UserState state, LoginUserAction action)
        {
            return new UserState(new UserData() { Id = Guid.NewGuid(), Username = action.Username });
        }
    }
}
