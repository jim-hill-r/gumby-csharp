using Gremlin.Net.Driver;
using Gremlin.Net.Driver.Messages;
using Gumby.Api.GraphQL.Journal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    public class PostResolver
    {
        IGremlinClient _gremlinClient;
        public PostResolver(IGremlinClient gremlinClient)
        {
            _gremlinClient = gremlinClient;
        }

        public async Task<Post> GetPostAsync(Guid id)
        {
            string query = $"g.V('{id}').has('partitionKey','post')";
            var result = await _gremlinClient.SubmitAsync<dynamic>(query);
            var postResult = result.FirstOrDefault();
            return new Post();
        }

        public async Task<IReadOnlyList<Post>> GetPostsAsync()
        {
            string query = $"g.V().hasLabel('post')";
            var result = await _gremlinClient.SubmitAsync<dynamic>(query);

            return new List<Post>()
            {
                new Post()
                {
                    Text = "Redpoint?"
                }

            };
        }

        
        public async Task<Guid> CreatePostAsync()
        {
            var newId = Guid.NewGuid();
            string query = $"g.addV('post').property('id', '{newId}').property('partitionKey','post').property('text','')";
            var result = await _gremlinClient.SubmitAsync<dynamic>(query);
            return newId;
        }
    }
}
