using Blazor.Fluxor;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

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
                var newJournalData = new JournalData()
                {
                    Id = Guid.NewGuid(),
                    Name = action.Name,
                    OccurredAt = action.OccurredAt ?? DateTime.UtcNow,
                    ProtectionType = action.ProtectionType ?? ProtectionType.NONE
                };

                var stringPayload = await Task.Run(() => JsonSerializer.ToString(newJournalData));

                HttpContent httpContent = new StringContent(stringPayload);
                await HttpClient.PostAsync($"{API_ROOT}/{API_ENDPOINT}", httpContent);
            }
            catch
            {
                // Should really dispatch an error action
            }
            var completeAction = new FetchJournalAction();
            dispatcher.Dispatch(completeAction);
        }
    }
}
