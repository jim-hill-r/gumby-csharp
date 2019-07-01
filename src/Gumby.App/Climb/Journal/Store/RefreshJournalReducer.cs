using System;
using System.Linq;
using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;

namespace Gumby.App.Climb.Journal.Store
{
    public class RefreshJournalReducer : Reducer<JournalState, RefreshJournalAction>
    {
        public override JournalState Reduce(JournalState state, RefreshJournalAction action)
        {
            return state;
            var journalTask = JournalService.GetManyJournal();
            return new JournalState(journalTask.Result.ToList(), state.RouteNames);
        }
    }
}
