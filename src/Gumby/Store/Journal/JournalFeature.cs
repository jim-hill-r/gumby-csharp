using Blazor.Fluxor;
using Gumby.Contract.Journal;
using System.Collections.Generic;

namespace Gumby.Store.Journal
{
    public class ClimbFeature : Feature<JournalState>
    {
        public override string GetName() => "Journal";
        protected override JournalState GetInitialState() => new JournalState(new List<IJournalData>());
    }
}
