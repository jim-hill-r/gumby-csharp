using Gumby.App;
using Gumby.App.Climb.Journal.Store;
using System;
using System.Net.Http;
using Xunit;

namespace Gumby.Test.Unit.App
{
    public class FetchJournalEffectTest
    {
        [Fact]
        public void HandleReturnsPosts()
        {
            HttpClient httpClient = new HttpClient();
            IEndpointProvider endpointProvider = new EndpointProvider();
            var fetchJournalEffect = new FetchJournalEffect(httpClient,endpointProvider);


        }
    }
}
