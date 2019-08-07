using Blazor.Fluxor;
using Gumby.Graph.Vertex.Climb.Journal;
using System;

namespace Gumby.App.Climb.Journal.Store
{
    public class AddJournalReducer : Reducer<JournalState, AddJournalAction>
    {
        public override JournalState Reduce(JournalState state, AddJournalAction action)
        {
            var newJournalData = new PostFull()
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
