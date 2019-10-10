using System;

namespace Gumby.Graph
{
    public interface IGumbyGraph
    {
        T AddVertex<T>(T vertex);
        T AddEdge<T>(T edge);
    }
}
