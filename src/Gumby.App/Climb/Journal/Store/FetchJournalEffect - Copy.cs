using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
