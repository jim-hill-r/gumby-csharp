using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Graph
{
    public interface IEdge
    {
        Guid Id { get; set; }
        string Label { get; }
        string Partition { get; }
    }
}
