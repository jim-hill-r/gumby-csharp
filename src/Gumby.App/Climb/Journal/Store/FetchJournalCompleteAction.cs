using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalCompleteAction : IAction
    {
        public readonly List<JournalData> Journals;

        public FetchJournalCompleteAction(List<JournalData> journals)
        {
            this.Journals = journals;
        }
    }
}
