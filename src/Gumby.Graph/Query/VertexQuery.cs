using Gumby.Graph.Vertex;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gumby.Graph.Query
{
    public class VertexQuery
    {
        public async Task<List<T>> GetManyAsync<T>(int page) where T:VertexChunk
        {
            return new List<T>();
        }

        public async Task CreateAsync<T>(T vertex) where T : VertexChunk
        {
            return;
        }
    }
}
