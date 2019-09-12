using Gumby.App.Climb.Journal.Models;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class FetchJournalCompleteAction
    {
        public readonly List<Post> Posts;

        public FetchJournalCompleteAction(List<Post> posts)
        {
            this.Posts = posts;
        }
    }
}
