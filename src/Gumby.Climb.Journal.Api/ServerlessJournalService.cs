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
            var journalData = new JournalData()
            {
                Id = id
            };

            return new OkObjectResult(journalData);
        }

        private class JournalData : IJournalData
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public DateTimeOffset OccurredAt { get; set; }
            public Guid RouteId { get; set; }
            public string RouteName { get; set; }
            public ProtectionType ProtectionType { get; set; }
        }
    }
}
