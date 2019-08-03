using Gumby.Climb.Route.Contract;
using System;
using System.Collections.Generic;

namespace Gumby.Climb.Journal.Contract
{
    public class JournalData
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTimeOffset OccurredAt { get; set; }

        public Guid UserId { get; set; }
                
        public string Text { get; set; }

        public Guid RouteId { get; set; }
        public ProtectionType? ProtectionType { get; set; }
        public List<string> Images { get; set; }
    }
}
