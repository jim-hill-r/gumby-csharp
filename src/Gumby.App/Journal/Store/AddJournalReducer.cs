using Blazor.Fluxor;
using Gumby.App.Journal.Models;
using System;

namespace Gumby.App.Climb.Journal.Store
{
    public class AddJournalReducer : Reducer<JournalState, AddJournalAction>
    {
        public override JournalState Reduce(JournalState state, AddJournalAction action)
        {
            var newJournalData = new Post()
            {
                Id = Guid.NewGuid(),
                Text = action.Name,
                OccurredAt = action.OccurredAt ?? DateTime.UtcNow
            };
            state.Posts.Insert(0, newJournalData);

            return state;
        }
    }
}
