using System;

namespace Gumby.Contract.Route
{
    public interface IRouteData
    {
        Guid Id { get; }
        DateTime OriginationDate { get; }
        Guid RouteId { get; }
        string RouteName { get; }
    }
}
