using Gumby.Contract.User;

namespace Gumby.Contract.Journal
{
    public interface IUserService
    {
        IUserData GetGuestUser();
    }
}
