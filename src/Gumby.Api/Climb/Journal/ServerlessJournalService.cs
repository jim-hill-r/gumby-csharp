using Gumby.Graph.Query;
using Gumby.Graph.Vertex.Climb.Journal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Gumby.Api.Climb.Journal
{
    public static class ServerlessJournalService
    {
        [FunctionName("GetPosts")]
        public static async Task<IActionResult> GetManyPosts(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "journal/posts/{page}")]
            HttpRequest req,
            ILogger log,
            int page)
        {
            VertexQuery vertexQuery = new VertexQuery();
            var posts = await vertexQuery.GetManyAsync<PostFull>(page);
            return new OkObjectResult(posts);
        }
        
        [FunctionName("CreateJournal")]
        public static async Task<IActionResult> CreatePost(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "journal/posts")]
            HttpRequest req,
            ILogger log)
        {
            var requestBodyTask = new StreamReader(req.Body).ReadToEndAsync();

            VertexQuery vertexQuery = new VertexQuery();
            PostFull postBody = JsonConvert.DeserializeObject<PostFull>(await requestBodyTask);
            vertexQuery.CreateAsync(postBody);
            return new AcceptedResult();
        }
    }
}
