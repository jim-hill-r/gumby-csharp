using Gumby.Graph.Vertex.Climb.Journal;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalState
    {
        public List<PostFull> Posts { get; private set; }

        public JournalState()
        {
            this.Posts = new List<PostFull>();
        }
        public JournalState(List<PostFull> posts)
        {
            Posts = posts;
        }
    }
}
