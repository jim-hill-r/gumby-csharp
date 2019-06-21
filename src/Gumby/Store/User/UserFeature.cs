using Blazor.Fluxor;
using Gumby.Contract.Journal;
using Gumby.Model.User;
using Gumby.Services.User;
using System;

namespace Gumby.Store.User
{
    public class UserFeature : Feature<UserState>
    {
        private IUserService _userService;
        public UserFeature()
        {
            _userService = new NativeUserService();
        }
        public override string GetName() => "User";
        protected override UserState GetInitialState() => 
            new UserState(
                new UserData()
                {
                    Id = Guid.Empty,
                    Username = "Guest"
                }
            );
    }
}
