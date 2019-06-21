using Blazor.Fluxor;
using Gumby.Contract.Journal;
using Gumby.Contract.Route;
using Gumby.Model.Journal;
using System;

namespace Gumby.Store.Journal
{
    public class AddJournalReducer : Reducer<JournalState, AddJournalAction>
    {
        public override JournalState Reduce(JournalState state, AddJournalAction action)
        {
            state.Journals.Insert(0, action.JournalData);
            return state;
        }
    }
}
