using Gumby.User.Contract;
using System;

namespace Gumby.User.Domain
{
    public static class UserFactory
    {
        public static IUserData GUEST_USER
        {
            get
            {
                return new UserData
                {
                    Id = Guid.Empty,
                    Username = "Login"
                };
            }
        }

        private class UserData : IUserData
        {
            public Guid Id { get; set; }
            public string Username { get; set; }
        }
    }
}
