using System;

namespace Gumby.Contract
{
    public interface IClimb
    {
        Guid Id { get; }
        DateTimeOffset OccurredAt { get; }
        Guid RouteId { get; }
        string RouteName { get; }
    }
}
