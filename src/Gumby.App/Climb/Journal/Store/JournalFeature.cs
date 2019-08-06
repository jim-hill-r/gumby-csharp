using Blazor.Fluxor;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalFeature : Feature<JournalState>
    {
        public override string GetName() => "Journal";
        protected override JournalState GetInitialState() => new JournalState();
    }
}
