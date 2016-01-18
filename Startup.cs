using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using log4net;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace file_storage
{
    public class Startup
    {
      private static ILog Log = log4net.LogManager.GetLogger(typeof(Startup));
      
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
          Console.WriteLine("Entry ConfigureServices");
          Log.Debug("Entry ConfigureServices");
          
          // Add framework services.
          services.AddMvc();
            
          var containerBuilder = new ContainerBuilder();
          containerBuilder.RegisterModule(new AutoFacModule());
          containerBuilder.Populate(services);
          var container = containerBuilder.Build();
          return container.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseIISPlatformHandler();

            app.UseStaticFiles();

            app.UseMvc();
        }

        // Entry point for the application.
        public static void Main(string[] args) => Microsoft.AspNet.Hosting.WebApplication.Run<Startup>(args);
    }
}
