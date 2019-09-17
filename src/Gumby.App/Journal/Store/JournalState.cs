using Gumby.App.Journal.Models;
using System.Collections.Generic;

namespace Gumby.App.Climb.Journal.Store
{
    public class JournalState
    {
        public List<Post> Posts { get; private set; }

        public JournalState()
        {
            this.Posts = new List<Post>();
        }
        public JournalState(List<Post> posts)
        {
            Posts = posts;
        }
    }
}
