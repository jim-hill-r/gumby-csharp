using System;

namespace Gumby.Contract
{
    public interface IClimb
    {
        Guid Id { get; }
        DateTime OccurredAt { get; }
        TimeZoneInfo OccuredAtTimezone { get; }
        Guid RouteId { get; }
        string RouteName { get; }
    }
}
