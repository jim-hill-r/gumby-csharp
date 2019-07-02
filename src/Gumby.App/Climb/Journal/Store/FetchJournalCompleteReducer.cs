using System;
using System.Linq;
using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalCompleteReducer : Reducer<JournalState, FetchJournalCompleteAction>
    {
        public override JournalState Reduce(JournalState state, FetchJournalCompleteAction action)
        {
            return new JournalState
            (
                journals: action.Journals.OrderByDescending(j => j.OccurredAt).ToList(), 
                routeNames: state.RouteNames                
            );
        }
    }
}
