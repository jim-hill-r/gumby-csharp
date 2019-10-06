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

        public IReadOnlyList<Post> GetPosts()
        {
            string query = "g.V().hasLabel('post')";

            var results = _gremlinClient.SubmitAsync<dynamic>(query).Result;

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
