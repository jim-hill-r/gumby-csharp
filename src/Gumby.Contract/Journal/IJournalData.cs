using System;

namespace Gumby.Contract.Journal
{
    public interface IJournalData
    {
        Guid Id { get; }
        string Name { get; }
        DateTimeOffset OccurredAt { get; }
        Guid RouteId { get; }
        string RouteName { get; }
        Guid ProtectionId { get; }
        string ProtectionName { get; }
    }
}
