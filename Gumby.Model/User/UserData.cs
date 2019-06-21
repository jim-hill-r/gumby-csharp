using Gumby.Contract.User;
using System;

namespace Gumby.Model.User
{
    public class UserData : IUserData
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}
