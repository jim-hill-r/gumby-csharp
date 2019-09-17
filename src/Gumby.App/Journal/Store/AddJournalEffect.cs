using Blazor.Fluxor;
using Gumby.App.Journal.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gumby.App.Climb.Journal.Store
{
    public class AddJournalEffect : Effect<AddJournalAction>
    {
        private readonly HttpClient HttpClient;

        public AddJournalEffect(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected async override Task HandleAsync(AddJournalAction action, IDispatcher dispatcher)
        {
            HttpContent httpContent = null;
            try
            {
                var newJournalData = new Post()
                {
                    Id = Guid.NewGuid(),
                    Text = action.Name,
                    OccurredAt = action.OccurredAt ?? DateTime.UtcNow
                };
                await HttpClient.PostAsync(Endpoints.GraphQLAPI, httpContent);
            }
            catch
            {
                // Should really dispatch an error action
            }
            var completeAction = new FetchJournalAction();
            //dispatcher.Dispatch(completeAction);
        }
    }
}
