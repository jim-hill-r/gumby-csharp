using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Graph
{
    public interface IVertex
    {
        Guid Id { get; set; }
        string Label { get; }
        string Partition { get; }
        IDictionary<string,string> Properties { get; }
    }
}
