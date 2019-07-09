using Gumby.Climb.Database;
using Gumby.Climb.Journal.Contract;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

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

        /*[FunctionName("CheckOptions")]
        public static async Task<HttpResponseMessage> CheckOptions(
            [HttpTrigger(AuthorizationLevel.Anonymous, "options", Route = "{*path}")]
            HttpRequest req,
            ILogger log)
        {
            var res = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);

            if(req.Headers.ContainsKey("Origin") && req.Headers.ContainsKey("Access-Control-Request-Headers"))
            {
                res.Headers.Add("Connection", "keep-alive");
                res.Headers.Add("Access-Control-Allow-Origin", req.Headers["Origin"].First());
                res.Headers.Add("Access-Control-Allow-Methods", "POST, GET, OPTIONS, DELETE");
                res.Headers.Add("Access-Control-Allow-Headers", "content-type");
                res.Headers.Add("Access-Control-Max-Age", "86400");
                res.StatusCode = System.Net.HttpStatusCode.NoContent;
            }            

            return res;
        }*/
    }
}
