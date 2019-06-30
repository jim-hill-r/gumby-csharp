using Gumby.Climb.Journal.Contract;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gumby.App.Climb.Journal
{
    public static class JournalService
    {
        public static async Task<IEnumerable<JournalData>> GetManyJournal()
        {
            HttpClient client = new HttpClient();

            return await client.GetJsonAsync<IEnumerable<JournalData>>("https://gumbysl.azurewebsites.net/api/journal?code=Baz9tg0TQIaTOA0fHPKa0afcoOLnNzOcR3aV3eHj5QR30vg5wLD6oA==");
        }
        public static async Task CreateJournal(JournalData journal)
        {
            HttpClient client = new HttpClient();
            
            await client.PostJsonAsync("https://gumbysl.azurewebsites.net/api/journal/", journal);
        }
    }
}
