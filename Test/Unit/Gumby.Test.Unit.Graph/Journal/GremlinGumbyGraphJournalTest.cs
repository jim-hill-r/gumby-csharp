using Gremlin.Net.Driver;
using Gremlin.Net.Structure.IO.GraphSON;
using Gumby.Graph;
using Gumby.Graph.Cosmos;
using Gumby.Graph.Journal.Models;
using System;
using Xunit;

namespace Gumby.Test.Unit.Graph.Journal
{
    public class GremlinGumbyGraphJournalTest
    {
        private readonly IGumbyGraph _gumbyGraph;

        public GremlinGumbyGraphJournalTest()
        {
            var gremlinServer = new GremlinServer("localhost", 8901, enableSsl: false,
                                                username: "/dbs/gumbydb/colls/gumbygraph",
                                                password: "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
            var gremlinClient = new GremlinClient(gremlinServer, new GraphSON2Reader(), new GraphSON2Writer(), GremlinClient.GraphSON2MimeType);
            _gumbyGraph = new CosmosGumbyGraph(gremlinClient);
        }
        [Fact]
        public void AddVertexTest()
        {
            var testVertex = new PostVertex()
            {
                Id = Guid.NewGuid(),
                Text = "Test Text"
            };

            var queryBuilder = new GumbyGraphWriteQueryBuilder();
            queryBuilder.AddVertex(testVertex);
            IGumbyGraphWriteRequest testQuery = queryBuilder.Build();
            _gumbyGraph.WriteAsync(testQuery);
        }
    }
}
