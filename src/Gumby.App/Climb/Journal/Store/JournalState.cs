using Gumby.Climb.Journal.Contract;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalState
    {
        public List<IJournalData> Journals { get; private set; }

        public JournalState(List<IJournalData> journals)
        {
            Journals = journals;
        }
    }
}
