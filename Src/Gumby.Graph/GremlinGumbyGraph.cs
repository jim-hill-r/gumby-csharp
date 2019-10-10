using Gremlin.Net.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gumby.Graph
{
    public class GremlinGumbyGraph : IGumbyGraph
    {
        private IGremlinClient _gremlinClient;
        public GremlinGumbyGraph(IGremlinClient gremlinClient)
        {
            _gremlinClient = gremlinClient;
        }
        
        public async Task<Guid> AddVertexAsync<T>(T vertex) where T : IVertex
        {
            var queryBuilder = new StringBuilder();
            queryBuilder.Append($"g");
            queryBuilder.Append($".addV('{vertex.Label}'");
            queryBuilder.Append($".property('id','{vertex.Id}'");
            queryBuilder.Append($".property('partitionKey','{vertex.Partition}'");
            foreach(string key in vertex.Properties.Keys)
            {
                queryBuilder.Append($".property('{key}','{vertex.Properties[key]}'");
            }
                        
            var result = await _gremlinClient.SubmitAsync<dynamic>(queryBuilder.ToString());
            return vertex.Id;
        }

        public async Task<Guid> AddEdgeAsync<T>(T edge) where T : IEdge
        {
            throw new NotImplementedException();
        }

    }
}
