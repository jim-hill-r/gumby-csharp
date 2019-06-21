using System;

namespace Gumby.Contract.Route
{
    public interface IProtectionData
    {
        Guid Id { get; }
        string DisplayName { get; }
    }
}
