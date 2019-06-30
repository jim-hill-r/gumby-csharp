using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Gumby.Climb.Journal.Contract;
using Gumby.Climb.Route.Contract;
using System.Data.SqlClient;
using Gumby.Climb.Database;

namespace Gumby.Climb.Journal.Api
{
    public static class ServerlessJournalService
    {
        [FunctionName("GetJournal")]
        public static async Task<IActionResult> GetJournal(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "journal/{id}")]
            HttpRequest req, 
            ILogger log,
            Guid id)
        {
            var str = Environment.GetEnvironmentVariable("GumbySQL-Connection");
            using (var journalRepository = new AzureSQLJournalRepository(str))
            {
                var journalData = await journalRepository.GetAsync(id);
                return new OkObjectResult(journalData);
            }
        }

        [FunctionName("GetJournal")]
        public static async Task<IActionResult> CreateJournal(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "journal")]
            HttpRequest req,
            ILogger log)
        {
            var str = Environment.GetEnvironmentVariable("GumbySQL-Connection");
            using (var journalRepository = new AzureSQLJournalRepository(str))
            {
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                IJournalData journalBody = JsonConvert.DeserializeObject<IJournalData>(requestBody);
                journalRepository.CreateAsync(journalBody);
                return new AcceptedAtRouteResult(journalBody.Id, journalBody);
            }
        }
    }
}
