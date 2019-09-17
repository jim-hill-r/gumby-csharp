using System;

namespace Gumby.App.Climb.Journal.Store
{
    public class AddJournalAction
    {
        public string Name { get; set; }
        public DateTime? OccurredAt { get; set; }
    }
}
