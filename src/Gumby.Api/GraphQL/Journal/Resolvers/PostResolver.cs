using Gremlin.Net.Driver;
using Gumby.Api.GraphQL.Journal.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    internal class PostResolver
    {
        IGremlinClient _gremlinClient;
        public PostResolver(IGremlinClient gremlinClient)
        {
            _gremlinClient = gremlinClient;
        }

        public async Task<IReadOnlyList<Post>> GetPostsAsync()
        {
            string getPostsQuery = $"g.V().hasLabel('post')";
            var results = await _gremlinClient.SubmitAsync<dynamic>(getPostsQuery);

            return new List<Post>()
            {
                new Post()
                {
                    Text = "Redpoint?"
                }

            };
        }

        
        public async Task<Post> CreatePostAsync()
        {
            var newId = Guid.NewGuid();
            string createPostQuery = $"g.addV('post').property('id', '{newId}')";
            var results = await _gremlinClient.SubmitAsync<dynamic>(createPostQuery);

            return new Post()
            {
                Id = newId,
                Text = "New Redpoint?"
            };
        }
    }
}
