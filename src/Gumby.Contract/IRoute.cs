using System;

namespace Gumby.Contract
{
    public interface IRoute
    {
        Guid Id { get; }
        DateTime OriginatedAt { get; }
        Guid RouteId { get; }
        string RouteName { get; }
    }
}
