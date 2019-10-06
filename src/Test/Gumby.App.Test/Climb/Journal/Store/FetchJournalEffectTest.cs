using Gumby.App.Climb.Journal.Store;
using System;
using System.Net.Http;
using Xunit;

namespace Gumby.App.Test
{
    public class FetchJournalEffectTest
    {
        [Fact]
        public void HandleReturnsPosts()
        {
            HttpClient httpClient = new HttpClient();
            var fetchJournalEffect = new FetchJournalEffect(httpClient);


        }
    }
}
