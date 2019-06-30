using System;
using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;

namespace Gumby.App.Climb.Journal.Store
{
    public class AddJournalReducer : Reducer<JournalState, AddJournalAction>
    {
        public override JournalState Reduce(JournalState state, AddJournalAction action)
        {
            state.Journals.Insert(0, new JournalData()
            {
                Id = Guid.NewGuid(),
                Name = action.Name,
                OccurredAt = action.OccurredAt ?? DateTime.UtcNow,
                ProtectionType = action.ProtectionType ?? ProtectionType.NONE
            });

            return state;
        }

        private class JournalData : IJournalData
        {
            public Guid Id { get; set; }
            public string Name { get; set; }

            public DateTimeOffset OccurredAt { get; set; }

            public Guid RouteId { get; set; }

            public string RouteName { get; set; }

            public ProtectionType ProtectionType { get; set; }


        }
    }
}
