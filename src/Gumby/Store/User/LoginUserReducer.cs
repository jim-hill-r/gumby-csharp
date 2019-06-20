using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Fluxor;
using Gumby.Model.User;

namespace Gumby.Store.User
{
    public class LoginUserReducer : Reducer<UserState, LoginUserAction>
    {
        public override UserState Reduce(UserState state, LoginUserAction action)
        {
            return new UserState(new UserMinimal() { Id = Guid.NewGuid(), Username = action.Username });
        }
    }
}
