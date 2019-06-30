using Gumby.Climb.Route.Contract;
using System;

namespace Gumby.Climb.Journal.Contract
{
    public class JournalData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? OccurredAt { get; set; }
        public ProtectionType? ProtectionType { get; set; }
    }
}
