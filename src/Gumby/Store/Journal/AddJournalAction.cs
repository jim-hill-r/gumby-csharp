using Blazor.Fluxor;
using Gumby.Model.Journal;
using System;

namespace Gumby.Store.Journal
{
    public class AddJournalAction : IAction
    {
        public JournalData JournalData { get; }
        
        public AddJournalAction(JournalData newJournalData)
        {
            JournalData = newJournalData;
        }
    }
}
