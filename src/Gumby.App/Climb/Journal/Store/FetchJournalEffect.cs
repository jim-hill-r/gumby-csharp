using Blazor.Fluxor;
using Gumby.App.Climb.Journal.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalEffect : Effect<FetchJournalAction>
    {
        private readonly HttpClient HttpClient;

        public FetchJournalEffect(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected async override Task HandleAsync(FetchJournalAction action, IDispatcher dispatcher)
        {
            HttpContent httpContent = null;

            var journals = new List<Post>();
            try
            {
                var response = await HttpClient.PostAsync(Endpoints.GraphQLAPI,httpContent);
            }
            catch
            {
                // Should really dispatch an error action
            }
            var completeAction = new FetchJournalCompleteAction(journals);
            dispatcher.Dispatch(completeAction);
        }
    }
}
