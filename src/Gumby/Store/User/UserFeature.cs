using Blazor.Fluxor;
using Gumby.Contract;
using Gumby.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Store.User
{
    public class UserFeature : Feature<UserState>
    {
        public override string GetName() => "user";
        protected override UserState GetInitialState() => new UserState(UserMinimal.Guest);
    }
}
