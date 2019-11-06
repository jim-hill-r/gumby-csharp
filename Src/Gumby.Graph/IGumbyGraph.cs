using System;
using System.Threading.Tasks;

namespace Gumby.Graph
{
    public interface IGumbyGraph
    {
        Task<T> GetVertexAsync<T>(Guid id);
    }
}
