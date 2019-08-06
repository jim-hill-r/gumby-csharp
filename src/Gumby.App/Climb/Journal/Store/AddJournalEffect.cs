using Blazor.Fluxor;
using Gumby.Graph.Vertex.Climb.Journal;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gumby.App.Climb.Journal.Store
{
    public class AddJournalEffect : Effect<AddJournalAction>
    {
        public readonly string API_ROOT = "https://gumbysl.azurewebsites.net/api";
        public readonly string API_ENDPOINT = "journal";

        private readonly HttpClient HttpClient;

        public AddJournalEffect(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected async override Task HandleAsync(AddJournalAction action, IDispatcher dispatcher)
        {
            try
            {
                var newJournalData = new PostFull()
                {
                    Id = Guid.NewGuid(),
                    Text = action.Name,
                    OccurredAt = action.OccurredAt ?? DateTime.UtcNow
                };
                await HttpClient.PostJsonAsync<List<PostFull>>($"{API_ROOT}/{API_ENDPOINT}", newJournalData);
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
