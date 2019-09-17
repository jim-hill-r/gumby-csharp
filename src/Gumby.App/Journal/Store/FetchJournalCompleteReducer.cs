using Blazor.Fluxor;
using System.Linq;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalCompleteReducer : Reducer<JournalState, FetchJournalCompleteAction>
    {
        public override JournalState Reduce(JournalState state, FetchJournalCompleteAction action)
        {
            return new JournalState
            (
                posts: action.Posts.OrderByDescending(j => j.OccurredAt).ToList()               
            );
        }
    }
}
