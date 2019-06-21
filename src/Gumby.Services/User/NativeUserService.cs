using Gumby.Contract.Journal;
using Gumby.Contract.User;
using Gumby.Model.User;
using System;

namespace Gumby.Services.User
{
    public class NativeUserService : IUserService
    {
        public IUserData GetGuestUser()
        {
            return new UserData()
            {
                Id = Guid.Empty,
                Username = "Guest"
            };
        }
    }
}
