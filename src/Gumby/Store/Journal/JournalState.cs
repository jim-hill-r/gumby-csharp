using Gumby.Contract.Journal;
using System.Collections.Generic;

namespace Gumby.Store.Journal
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
