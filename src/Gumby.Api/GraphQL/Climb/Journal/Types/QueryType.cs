using Gumby.Repository;
using HotChocolate.Types;

namespace Gumby.Api.GraphQL.Types
{
    internal class QueryType : ObjectType<Query>
    {
        IClimbRepository _climbRepository;
        public QueryType(IClimbRepository climbRepository)
        {
            _climbRepository = climbRepository;
        }
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.Posts)
                .Resolver(_climbRepository.GetPosts());
        }
    }
}
