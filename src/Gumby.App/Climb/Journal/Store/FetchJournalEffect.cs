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
    public class FetchJournalEffect : Effect<FetchJournalAction>
    {
        public readonly string API_ROOT = "https://gumbysl.azurewebsites.net/api";
        public readonly string API_ENDPOINT = "journal";

        private readonly HttpClient HttpClient;

        public FetchJournalEffect(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected async override Task HandleAsync(FetchJournalAction action, IDispatcher dispatcher)
        {
            var journals = new List<JournalData>();
            try
            {
                var journalArray = await HttpClient.GetJsonAsync<JournalData[]>($"{API_ROOT}/{API_ENDPOINT}");
                journals = journalArray.ToList();
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
