using Gumby.Api.GraphQL.Journal.Models;
using Gumby.Graph;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    public class PostQueryResolver
    {
        IGumbyGraph _gumbyGraph;

        public PostQueryResolver(IGumbyGraph gumbyGraph)
        {
            _gumbyGraph = gumbyGraph;
        }

        public async Task<Post> GetPostAsync(Guid id)
        {
            return new Post();
        }

        public async Task<IReadOnlyList<Post>> GetPostsAsync()
        {
            return new List<Post>()
            {
                new Post()
                {
                    Text = "Redpoint?"
                }

            };
        }
    }
}
