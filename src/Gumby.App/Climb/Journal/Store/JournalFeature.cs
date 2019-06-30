using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalFeature : Feature<JournalState>
    {
        public override string GetName() => "Journal";
        protected override JournalState GetInitialState() => new JournalState(new List<IJournalData>());
    }
}
