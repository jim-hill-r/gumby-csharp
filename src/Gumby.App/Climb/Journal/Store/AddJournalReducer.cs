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
            var newJournalData = new JournalData()
            {
                Id = Guid.NewGuid(),
                Text = action.Name,
                OccurredAt = action.OccurredAt ?? DateTime.UtcNow,
                ProtectionType = action.ProtectionType ?? ProtectionType.NONE
            };
            state.Journals.Insert(0, newJournalData);

            return state;
        }
    }
}
