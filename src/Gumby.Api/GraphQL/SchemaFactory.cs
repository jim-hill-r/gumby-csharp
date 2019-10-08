using Gumby.Api.GraphQL.Journal.Types;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gumby.Api.GraphQL
{
    public static class SchemaFactory
    {
        public static ISchemaBuilder JournalSchema()
        {
            return SchemaBuilder.New()
                .AddQueryType<JournalQueryType>()
                .AddMutationType<JournalMutationType>()
                .AddType<PostType>();
        }
    }
}
