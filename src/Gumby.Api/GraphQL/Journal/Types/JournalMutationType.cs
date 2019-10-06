using Gumby.Api.GraphQL.Journal.Resolvers;
using HotChocolate.Types;

namespace Gumby.Api.GraphQL.Journal.Types
{
    internal class JournalMutationType : ObjectType<JournalMutation>
    {
        protected override void Configure(IObjectTypeDescriptor<JournalMutation> descriptor)
        {
            descriptor.Field<PostResolver>(t => t.GetPosts());
        }
    }
}
