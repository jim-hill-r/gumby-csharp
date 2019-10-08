using Gremlin.Net.Driver;
using Gumby.Api.GraphQL.Journal.Models;
using System.Collections.Generic;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    internal class PostResolver
    {
        IGremlinClient _gremlinClient;
        public PostResolver(IGremlinClient gremlinClient)
        {
            _gremlinClient = gremlinClient;
        }

        private static readonly string GetPostsQuery = "g.V().hasLabel('post')";
        public IReadOnlyList<Post> GetPosts()
        {
            var results = _gremlinClient.SubmitAsync<dynamic>(GetPostsQuery).Result;

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
