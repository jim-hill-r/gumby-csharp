using Gumby.Api.GraphQL.Journal.Resolvers;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Gumby.Api.GraphQL.Journal.Types
{
    internal class JournalQueryType : ObjectType<JournalQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<JournalQuery> descriptor)
        {
            descriptor.Field<PostQueryResolver>(r => r.GetPostsAsync())
                .Name("posts");
        }
        
    }
}
