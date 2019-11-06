using Gumby.Api.GraphQL.Journal.Models;
using Gumby.Graph;
using Gumby.Graph.Journal.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    public class PostQueryResolver
    {
        IGumbyGraph _gumbyGraphReader;

        public PostQueryResolver(IGumbyGraph gumbyGraphReader)
        {
            _gumbyGraphReader = gumbyGraphReader;
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
