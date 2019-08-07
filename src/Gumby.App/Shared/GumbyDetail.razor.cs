using Gumby.Graph.Vertex;
using Microsoft.AspNetCore.Components;

namespace Gumby.App.Shared
{
    public class GumbyDetailBase : ComponentBase
    {
        [Parameter] public VertexChunk Value { get; set; }
    }
}
