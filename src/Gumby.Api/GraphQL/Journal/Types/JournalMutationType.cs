using Gumby.Api.GraphQL.Journal.Resolvers;
using HotChocolate.Types;

namespace Gumby.Api.GraphQL.Journal.Types
{
    internal class JournalMutationType : ObjectType<JournalMutation>
    {
        protected override void Configure(IObjectTypeDescriptor<JournalMutation> descriptor)
        {
            descriptor.Field<PostResolver>(r => r.CreatePostAsync())
                .Name("createPost");
        }
    }
}
