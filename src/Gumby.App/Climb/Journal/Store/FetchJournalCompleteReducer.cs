using System;
using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalCompleteReducer : Reducer<JournalState, FetchJournalCompleteAction>
    {
        public override JournalState Reduce(JournalState state, FetchJournalCompleteAction action)
        {
            Console.WriteLine(action.Journals.ToString());
            foreach(var journal in action.Journals)
            {
                Console.WriteLine(journal.ToString());
            }
            return new JournalState
            (
                journals: action.Journals, 
                routeNames: state.RouteNames                
            );
        }
    }
}
