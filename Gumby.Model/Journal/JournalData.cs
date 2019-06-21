using Gumby.Contract.Journal;
using System;

namespace Gumby.Model.Journal
{
    public class JournalData : IJournalData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public DateTimeOffset OccurredAt { get; set; }

        public Guid RouteId { get; set; }

        public string RouteName { get; set; }
        public Guid ProtectionId { get; set; }
        public string ProtectionName { get; set; }
    }
}
