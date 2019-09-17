using Gumby.Repository.Climb.Journal.Models;
using Gumby.Repository.Journal;
using System.Collections.Generic;

namespace Gumby.Graph.Journal
{
    public class GraphJournalRepository : IJournalRepository
    {
        public IReadOnlyList<Post> GetPosts()
        {
            return new List<Post>()
            {
                new Post()
                {
                    Text = "Test"
                }
            };
        }
    }
}
