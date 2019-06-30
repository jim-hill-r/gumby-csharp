using Blazor.Fluxor;
using Gumby.Climb.Route.Contract;
using System;

namespace Gumby.App.Climb.Journal.Store
{
    public class AddJournalAction : IAction
    {
        public string Name { get; set; }
        public DateTime? OccurredAt { get; set; }
        public ProtectionType? ProtectionType { get; set; }
    }
}
