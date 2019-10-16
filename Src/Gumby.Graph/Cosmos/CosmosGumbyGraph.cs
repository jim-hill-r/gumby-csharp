using Gremlin.Net.Driver;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Gumby.Graph.Cosmos
{
    public class CosmosGumbyGraph : IGumbyGraph
    {
        private static readonly string PARTITION_KEY = "partitionKey";
        private static readonly string ID_KEY = "id";

        private IGremlinClient _gremlinClient;
        public CosmosGumbyGraph(IGremlinClient gremlinClient)
        {
            _gremlinClient = gremlinClient;
        }

        public async Task<T> ReadAsync<T>(IGumbyGraphReadRequest query)
        {
            throw new NotImplementedException();
        }

        public async Task WriteAsync(IGumbyGraphWriteRequest query)
        {
            var queryBuilder = new StringBuilder();
            queryBuilder.Append($"g");
            foreach (object o in query.GetObjects())
            {
                if(o is IVertex)
                {
                    var vertex = (IVertex)o;
                    queryBuilder.Append($".addV('{vertex.Label}')");
                    queryBuilder.Append($".property('{ID_KEY}','{vertex.Id}')");
                    queryBuilder.Append($".property('{PARTITION_KEY}','{vertex.Partition}')");
                    foreach (string key in vertex.Properties.Keys)
                    {
                        queryBuilder.Append($".property('{key}','{vertex.Properties[key]}')");
                    }
                }
            }

            var result = await _gremlinClient.SubmitAsync<dynamic>(queryBuilder.ToString());
            
        }
    }
}
