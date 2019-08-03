using Gumby.Climb.Journal.Contract;
using System;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalState
    {
        public List<JournalData> Journals { get; private set; }

        public JournalState()
        {
            this.Journals = new List<JournalData>();
        }
        public JournalState(List<JournalData> journals)
        {
            Journals = journals;
        }
    }
}
