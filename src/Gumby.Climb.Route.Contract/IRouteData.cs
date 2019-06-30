using System;

namespace Gumby.Climb.Route.Contract
{
    public interface IRouteData
    {
        Guid Id { get; }
        DateTime OriginationDate { get; }
        string RouteName { get; }
    }
}
