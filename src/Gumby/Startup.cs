using Blazor.Fluxor;
using Gumby.Contract.Journal;
using Gumby.Contract.Route;
using Gumby.Services.Route;
using Gumby.Services.User;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace Gumby
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFluxor(options => options
                .UseDependencyInjection(typeof(Startup).Assembly)
            );

            services.AddSingleton<IJournalService, NativeJournalService>();
            services.AddSingleton<IProtectionService, NativeProtectionService>();
            services.AddSingleton<IRouteService, NativeRouteService>();
            services.AddSingleton<IUserService, NativeUserService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.UseLocalTimeZone();
            app.AddComponent<App>("app");
        }
    }
}
