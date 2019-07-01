using Gumby.Climb.Database;
using Gumby.Climb.Journal.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Gumby.Climb.Journal.Api
{
    public static class ServerlessJournalService
    {
        [FunctionName("GetManyJournal")]
        public static async Task<IActionResult> GetManyJournal(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "journal")]
            HttpRequest req,
            ILogger log)
        {
            var str = Environment.GetEnvironmentVariable("GumbySQL-Connection");
            var journalRepository = new AzureSQLJournalRepository(str);
            var journalData = await journalRepository.GetManyAsync(10);
            return new OkObjectResult(journalData);
        }

        [FunctionName("GetJournal")]
        public static async Task<IActionResult> GetJournal(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "journal/{id}")]
            HttpRequest req, 
            ILogger log,
            string id)
        {
            Guid guid = new Guid(id);
            var str = Environment.GetEnvironmentVariable("GumbySQL-Connection");
            var journalRepository = new AzureSQLJournalRepository(str);
            var journalData = await journalRepository.GetAsync(guid);
            return new OkObjectResult(journalData);
        }

        [FunctionName("CreateJournal")]
        public static async Task<IActionResult> CreateJournal(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "journal")]
            HttpRequest req,
            ILogger log)
        {
            var requestBodyTask = new StreamReader(req.Body).ReadToEndAsync();

            var str = Environment.GetEnvironmentVariable("GumbySQL-Connection");
            var journalRepository = new AzureSQLJournalRepository(str);
            JournalData journalBody = JsonConvert.DeserializeObject<JournalData>(await requestBodyTask);
            journalRepository.CreateAsync(journalBody);
            return new AcceptedResult();
        }
    }
}
