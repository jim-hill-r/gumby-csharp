using Gremlin.Net.Driver;
using Gremlin.Net.Structure.IO.GraphSON;
using Gumby.Api.GraphQL;
using Gumby.Graph;
using Gumby.Graph.Cosmos;
using Gumby.Mutation;
using Gumby.Mutation.Cosmos;
using HotChocolate;
using HotChocolate.Execution.Configuration;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

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
            var gremlinHost = Environment.GetEnvironmentVariable("gremlinHost");
            var gremlinPort = int.Parse(Environment.GetEnvironmentVariable("gremlinPort"));
            var gremlinEnableSsl = bool.Parse(Environment.GetEnvironmentVariable("gremlinSsl"));
            var gremlinPassword = Environment.GetEnvironmentVariable("gremlinPassword");

            var gumbyGraphGremlinServer = new GremlinServer(gremlinHost, gremlinPort, enableSsl: gremlinEnableSsl,
                                                username: "/dbs/gumbydb/colls/gumbygraph",
                                                password: gremlinPassword);
             var gumbyGraphGremlinClient = new GremlinClient(gumbyGraphGremlinServer, new GraphSON2Reader(), new GraphSON2Writer(), GremlinClient.GraphSON2MimeType);
            services.AddSingleton<IGumbyGraph>(new CosmosGumbyGraph(gumbyGraphGremlinClient));

            var mutationRepositoryGremlinServer = new GremlinServer(gremlinHost, gremlinPort, enableSsl: gremlinEnableSsl,
                                                username: "/dbs/gumbydb/colls/mutation",
                                                password: gremlinPassword);
            var mutationRepositoryGremlinClient = new GremlinClient(mutationRepositoryGremlinServer, new GraphSON2Reader(), new GraphSON2Writer(), GremlinClient.GraphSON2MimeType);
            services.AddSingleton<IGumbyGraph>(new CosmosGumbyGraph(gumbyGraphGremlinClient));
            services.AddSingleton<IMutationRepository>(new CosmosMutationRepository(mutationRepositoryGremlinClient));

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