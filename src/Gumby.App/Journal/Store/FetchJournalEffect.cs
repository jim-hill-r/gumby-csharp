using Blazor.Fluxor;
using Gumby.App.Journal.Models;
using System.Collections.Generic;
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
            string requestBody = 
              @"{
                 posts{
                  text       
                 }
                }";
            
            HttpContent httpContent = new StringContent(requestBody);

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
