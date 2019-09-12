using Gumby.Repository;
using Gumby.Repository.Models;
using System.Collections.Generic;

namespace Gumby.Graph
{
    public class GraphClimbRepository : IClimbRepository
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
