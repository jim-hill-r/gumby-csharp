using Gumby.Climb.Route.Contract;
using System;

namespace Gumby.Climb.Journal.Contract
{
    public interface IJournalData
    {
        Guid Id { get; }
        string Name { get; }
        DateTimeOffset OccurredAt { get; }
        Guid RouteId { get; }
        string RouteName { get; }
        ProtectionType ProtectionType { get; }
    }
}
