using Gumby.Api.GraphQL.Journal.Models;
using Gumby.Graph;
using Gumby.Graph.Journal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    public class PostResolver
    {
        IGumbyGraph _gumbyGraph;
        public PostResolver(IGumbyGraph gumbyGraph)
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

        
        public async Task<Guid> CreatePostAsync()
        {
            var newId = Guid.NewGuid();
            var postVertex = new PostVertex()
            {
                Id = newId
            };

            var query = new GumbyGraphWriteQueryBuilder()
                .AddVertex(postVertex)
                .Build();
            await _gumbyGraph.WriteAsync(query);
           
            return newId;
        }
    }
}
