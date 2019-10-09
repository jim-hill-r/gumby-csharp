using Gremlin.Net.Driver;
using Gremlin.Net.Structure.IO.GraphSON;
using Gumby.Api.GraphQL;
using HotChocolate;
using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Gumby.Api.GraphQL.Journal.Resolvers;

namespace Gumby.Api.Test
{
    public class PostResolverTest
    {
        private readonly IGremlinClient _gremlinClient;

        public PostResolverTest()
        {
            var gremlinServer = new GremlinServer("localhost", 8901, enableSsl: false,
                                                username: "/dbs/gumbydb/colls/gumbygraph",
                                                password: "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
            _gremlinClient = new GremlinClient(gremlinServer, new GraphSON2Reader(), new GraphSON2Writer(), GremlinClient.GraphSON2MimeType);

        }

        [Fact]
        public async Task CreatePostAsyncTest()
        {
            var postResolver = new PostResolver(_gremlinClient);
            var savedId = await postResolver.CreatePostAsync();
            var savedPost = await postResolver.GetPostAsync(savedId);
        }
    }
}
