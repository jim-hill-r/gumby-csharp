using Gremlin.Net.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Graph
{
    public class GremlinGumbyGraph : IGumbyGraph
    {
        private IGremlinClient _gremlinClient;
        public GremlinGumbyGraph(IGremlinClient gremlinClient)
        {
            _gremlinClient = gremlinClient;
        }
        
        public T AddVertex<T>(T vertex)
        {
            throw new NotImplementedException();
        }

        public T AddEdge<T>(T edge)
        {
            throw new NotImplementedException();
        }

    }
}
