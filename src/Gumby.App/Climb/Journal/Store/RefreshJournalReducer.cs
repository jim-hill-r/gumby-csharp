using System;
using System.Linq;
using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;

namespace Gumby.App.Climb.Journal.Store
{
    public class RefreshJournalReducer : Reducer<JournalState, AddJournalAction>
    {
        public override JournalState Reduce(JournalState state, AddJournalAction action)
        {
            var journalTask = JournalService.GetManyJournal();
            journalTask.Wait();
            return new JournalState(journalTask.Result.ToList(), state.RouteNames);
        }
    }
}
