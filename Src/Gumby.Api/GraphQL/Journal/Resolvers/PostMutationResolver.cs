using Gumby.Graph.Journal.Models;
using Gumby.Mutation;
using Gumby.Mutation.Journal.Models;
using System;
using System.Threading.Tasks;

namespace Gumby.Api.GraphQL.Journal.Resolvers
{
    public class PostMutationResolver
    {
        IMutationRepository _mutationRepository;

        public PostMutationResolver(IMutationRepository mutationRepository)
        {
            _mutationRepository = mutationRepository;
        }
        
        public async Task<Guid> CreatePostAsync()
        {
            var newId = Guid.NewGuid();
            var postMutation = new PostMutation()
            {
                Id = newId
            };

            await _mutationRepository.Submit(postMutation);
           
            return newId;
        }
    }
}
