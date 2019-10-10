using System;
using System.Threading.Tasks;

namespace Gumby.Graph
{
    public interface IGumbyGraph
    {
        Task<Guid> AddVertexAsync<T>(T vertex) where T : IVertex;
        Task<Guid> AddEdgeAsync<T>(T edge) where T : IEdge;
    }
}
