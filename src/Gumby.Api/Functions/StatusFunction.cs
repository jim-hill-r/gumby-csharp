using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Gumby.Api.Functions
{
    public class StatusFunction
    {

        [FunctionName("Status")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "onbelay")] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult("belayon");
        }
    }
}
