using DistrolateralServer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DistrolateralServer
{
    public class Startup
    {
        internal IServiceCollection Build(IServiceCollection services, IConfigurationSection store)
        {
            if (store.Exists())
            {
                return (store["storeType"]) switch
                {
                    "s3Bucket" => services.AddSingleton<IBucketStore, S3BucketStore>(),
                    _ => services.AddSingleton<IBucketStore, NoBucket>()
                };
            }
            return services.AddSingleton<IBucketStore, NoBucket>();
        }

        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            //    services.AddSingleton<IBucketStore, NoBucket>();

            Build(services, _config.GetSection("bucketStore"));
            //services.add
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GreeterService>();
                endpoints.MapGrpcService<DistroService>();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}
