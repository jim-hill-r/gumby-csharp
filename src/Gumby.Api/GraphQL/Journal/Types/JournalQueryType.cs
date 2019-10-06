using Gumby.Api.GraphQL.Journal.Resolvers;
using HotChocolate.Types;

namespace Gumby.Api.GraphQL.Journal.Types
{
    internal class JournalQueryType : ObjectType<JournalQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<JournalQuery> descriptor)
        {
            descriptor.Field<PostResolver>(t => t.GetPosts())
                .Type<PostType>();
        }
        
    }
}
