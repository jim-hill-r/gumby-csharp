using System;

namespace Gumby.Contract.User
{
    public interface IUserData
    {
        Guid Id { get; }
        string Username { get; }
    }
}
