using Blazor.Fluxor;
using System.Threading.Tasks;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalStoreInitializedEffect : Effect<StoreInitializedAction>
    {
        protected async override Task HandleAsync(StoreInitializedAction action, IDispatcher dispatcher)
        {
            dispatcher.Dispatch(new FetchJournalAction());
        }
    }
}
