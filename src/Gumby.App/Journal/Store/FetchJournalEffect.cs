using Blazor.Fluxor;
using Gumby.App.Journal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalEffect : Effect<FetchJournalAction>
    {
        private readonly HttpClient _httpClient;
        private readonly IEndpointProvider _endpointProvider;

        public FetchJournalEffect(HttpClient httpClient, IEndpointProvider endpointProvider)
        {
            _httpClient = httpClient;
            _endpointProvider = endpointProvider;
        }

        protected async override Task HandleAsync(FetchJournalAction action, IDispatcher dispatcher)
        {
            string requestBody = 
              @"{
                 posts{
                  text       
                 }
                }";

            Uri uri = new Uri(_endpointProvider.GraphQLAPI);
            HttpContent httpContent = new StringContent(requestBody, Encoding.UTF8);          

            try
            {
                var response = await _httpClient.PostAsync(uri,httpContent);
                if(response.Content != null)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var content = JsonConvert.DeserializeObject<ResponseContent>(responseContent);                    
                    var completeAction = new FetchJournalCompleteAction(content.Data.Posts);
                    dispatcher.Dispatch(completeAction);
                }
            }
            catch
            {
                // Should really dispatch an error action
            }
        }

        private class ResponseContent
        {
            public Data Data { get; set; }
        }

        private class Data
        {
            public List<Post> Posts { get; set; }
        }

    }
}
