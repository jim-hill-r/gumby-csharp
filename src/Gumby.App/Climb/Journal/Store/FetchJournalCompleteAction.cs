using Gumby.Graph.Vertex.Climb.Journal;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalCompleteAction
    {
        public readonly List<PostFull> Posts;

        public FetchJournalCompleteAction(List<PostFull> posts)
        {
            this.Posts = posts;
        }
    }
}
