using System;

namespace Gumby.Contract
{
    public interface IUser
    {
        Guid Id { get; }
        string Username { get; }
    }
}
