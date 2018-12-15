using ExtCore.Data.EntityFramework;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Reflection;
using TL.Engine.Middleware.Extenions;
using TL.Engine.Services;

namespace TL.Engine
{
    public class Startup
    {
        public IHostingEnvironment HostingEnvironment { get; }

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddExtCore(
                    Path.Combine(HostingEnvironment.ContentRootPath, Configuration["Extensions:Path"]),
                    Configuration["Extensions:IncludeSubpath"] == true.ToString()
                );

            services
               .Configure<StorageContextOptions>(options =>
               {
                   options.ConnectionString = Configuration.GetConnectionString("SqlServer");
                   options.MigrationsAssembly = typeof(DesignTimeStorageContextFactory).GetTypeInfo().Assembly.FullName;
               });
            DesignTimeStorageContextFactory.Initialize(services.BuildServiceProvider());
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePagesWithReExecute("/Error/{0}");
            app.UseRequestTimestamp();
            app.UseExtCore();
        }
    }
}
