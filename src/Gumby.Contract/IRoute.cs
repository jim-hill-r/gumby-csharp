using System;

namespace Gumby.Contract
{
    public interface IRoute
    {
        Guid Id { get; }
        DateTime OriginationDate { get; }
        Guid RouteId { get; }
        string RouteName { get; }
    }
}
