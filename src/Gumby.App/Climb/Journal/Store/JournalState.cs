using Gumby.Climb.Journal.Contract;
using System;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalState
    {
        public Dictionary<Guid,string> RouteNames { get; private set; }
        public List<JournalData> Journals { get; private set; }

        public JournalState(List<JournalData> journals, Dictionary<Guid,string> routeNames)
        {
            Journals = journals;
            RouteNames = routeNames;
        }
    }
}
