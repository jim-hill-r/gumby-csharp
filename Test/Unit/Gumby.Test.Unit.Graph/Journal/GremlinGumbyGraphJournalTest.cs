using Gremlin.Net.Driver;
using Gremlin.Net.Structure.IO.GraphSON;
using System;
using Xunit;

namespace Gumby.Test.Unit.Graph.Journal
{
    public class GremlinGumbyGraphJournalTest
    {
        private readonly IGremlinClient _gremlinClient;

        public GremlinGumbyGraphJournalTest()
        {
            var gremlinServer = new GremlinServer("localhost", 8901, enableSsl: false,
                                                username: "/dbs/gumbydb/colls/gumbygraph",
                                                password: "");
            _gremlinClient = new GremlinClient(gremlinServer, new GraphSON2Reader(), new GraphSON2Writer(), GremlinClient.GraphSON2MimeType);

        }
        [Fact]
        public void AddVertexTest()
        {

        }
    }
}
