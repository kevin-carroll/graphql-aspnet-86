using GraphQL.AspNet.Configuration.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace sample_project_netcoreapp31
{
    public class Startup
    {
        // Configures the service collection to be built for this application instance.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQL();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseGraphQL();
        }
    }
}