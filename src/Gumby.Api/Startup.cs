using Gumby.Api.GraphQL.Journal.Types;
using Gumby.Repository.Journal;
using Gumby.Graph.Journal;
using HotChocolate;
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
            services.AddScoped<IJournalRepository, GraphJournalRepository>();

            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddServices(sp)
                .AddQueryType<JournalQueryType>()
                .AddMutationType<JournalMutationType>()
                .AddType<PostType>()
                .Create()
            );
        }
    }
}