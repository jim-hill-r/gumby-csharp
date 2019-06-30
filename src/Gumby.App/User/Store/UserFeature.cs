using Blazor.Fluxor;
using Gumby.User.Domain;

namespace Gumby.App.User.Store
{
    public class UserFeature : Feature<UserState>
    {
        public override string GetName() => "User";
        protected override UserState GetInitialState() => new UserState(UserFactory.GUEST_USER);
    }
}
