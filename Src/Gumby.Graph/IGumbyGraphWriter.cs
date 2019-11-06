using Gumby.Graph.Journal.Models;
using System;
using System.Threading.Tasks;

namespace Gumby.Graph
{
    internal interface IGumbyGraphWriter
    {
        Task CreateVertexAsync<T>(T vertex) where T:IVertex;
        Task UpdateVertexAsync<T>(T vertex) where T:IVertex;
        Task DeleteVertexAsync<T>(Guid id) where T:IVertex;
    }
}
