using Blazor.Fluxor;
using Gumby.User.Contract;
using System;

namespace Gumby.App.User.Store
{
    public class LoginUserReducer : Reducer<UserState, LoginUserAction>
    {
        public override UserState Reduce(UserState state, LoginUserAction action)
        {
            return new UserState(new UserData() { Id = Guid.NewGuid(), Username = action.Username });
        }

        private class UserData : IUserData
        {
            public Guid Id { get; set; }
            public string Username { get; set; }
        }

    }
}
