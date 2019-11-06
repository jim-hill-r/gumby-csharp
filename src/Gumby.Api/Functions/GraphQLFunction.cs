using HotChocolate;
using HotChocolate.Execution;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Gumby.Api.Functions
{
    public class GraphQLFunction
    {
        private readonly IQueryExecutor _executor;

        public GraphQLFunction(IQueryExecutor executor)
        {
            _executor = executor;
        }

        [FunctionName("GraphQL")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "gql")] HttpRequest req,
            ILogger log)
        {
            var queryText = await req.ReadAsStringAsync();
            var queryRequest = QueryRequestBuilder.Create(queryText);
            var result = await _executor.ExecuteAsync(queryRequest);
            return new OkObjectResult(result.ToJson());
        }
    }
}
