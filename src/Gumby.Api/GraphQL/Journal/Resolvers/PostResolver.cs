using Gumby.Api.GraphQL.Journal.Models;
using System.Collections.Generic;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    internal class PostResolver
    {
        public IReadOnlyList<Post> GetPosts()
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
