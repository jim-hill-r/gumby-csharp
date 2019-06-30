using System;

namespace Gumby.User.Contract
{
    public interface IUserData
    {
        Guid Id { get; }
        string Username { get; }
    }
}
