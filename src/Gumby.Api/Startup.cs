using Gremlin.Net.Driver;
using Gremlin.Net.Structure.IO.GraphSON;
using Gumby.Api.GraphQL;
using Gumby.Api.GraphQL.Journal.Resolvers;
using Gumby.Api.GraphQL.Journal.Types;
using Gumby.Graph;
using HotChocolate;
using HotChocolate.Execution.Configuration;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Gumby.Api.Startup))]

namespace Gumby.Api
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureServices(builder.Services);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            var gremlinServer = new GremlinServer("localhost", 8091, enableSsl: false,
                                                username: "/dbs/gumbydb/colls/gumbygraph",
                                                password: "");
            var gremlinClient = new GremlinClient(gremlinServer, new GraphSON2Reader(), new GraphSON2Writer(), GremlinClient.GraphSON2MimeType);
            services.AddSingleton<IGremlinClient>(gremlinClient);

            services.AddSingleton<IGumbyGraph, GremlinGumbyGraph>();
            services.AddGraphQL(sp => SchemaFactory.JournalSchema()
                .AddServices(sp)
                .Create(),
                new QueryExecutionOptions
                {
                    TracingPreference = TracingPreference.Always
                }
            );
        }
    }
}