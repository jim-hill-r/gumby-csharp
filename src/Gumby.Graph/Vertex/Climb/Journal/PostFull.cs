using Gumby.Graph.Vertex.Climb.Route;
using Gumby.Graph.Vertex.Common.Image;
using Gumby.Graph.Vertex.Common.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Graph.Vertex.Climb.Journal
{
    public class PostFull : PostChunk
    {
        public DateTimeOffset OccurredAt;
        public UserChunk CreatedBy;
        public List<VertexChunk> Details;
    }
}
