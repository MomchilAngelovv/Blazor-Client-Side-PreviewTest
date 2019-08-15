using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Test1.Services;

namespace Test1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<BottleService>();
            services.AddSingleton<IPeopleService, PeopleService>();
            services.AddSingleton<IGlobalState, GlobalState>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
