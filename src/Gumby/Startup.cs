using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Blazor.Fluxor;
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
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.UseLocalTimeZone();
            app.AddComponent<App>("app");
        }
    }
}
