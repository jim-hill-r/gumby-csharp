using System;
using System.Threading.Tasks;

namespace Gumby.Graph
{
    public interface IGumbyGraph
    {
        Task<T> ReadAsync<T>(IGumbyGraphReadRequest query);
        Task WriteAsync(IGumbyGraphWriteRequest query);
    }
}
