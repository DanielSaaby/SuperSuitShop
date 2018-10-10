using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SuperSuitShop.Core.ApplicationService;
using SuperSuitShop.Core.ApplicationService.Implementation;
using SuperSuitShop.Core.DomainService;
using SuperSuitShop.Infrastructure.Data;
using SuperSuitShop.Infrastructure.Data.Repositories;

namespace SuperSuitShop.RestAPI
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        private IHostingEnvironment Env { get; set; }

        public Startup(IHostingEnvironment env)
        {
            Env = env;
            var builder = new ConfigurationBuilder()

                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors();

            if (Env.IsDevelopment())
            {
                services.AddDbContext<SuperSuitShopContext>(
                    opt => opt.UseSqlite("Data Source=SuperShop.DB"));
            }
            else if (Env.IsProduction())
            {
                services.AddDbContext<SuperSuitShopContext>(
                    opt => opt
                        .UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            }
                  
            services.AddScoped<ISuperSuitShopRepository, SuperSuitShopRepository>();
            services.AddScoped<ISuperSuitShopService, SuperSuitShopService>();

            services.AddMvc().AddJsonOptions(options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<SuperSuitShopContext>();
                    DbInitializer.SeedDb(ctx);
                }
            }
            else
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<SuperSuitShopContext>();
                    ctx.Database.EnsureCreated();
                }
                app.UseHsts();
            }

            app.UseCors("AllowAll");
            app.UseHttpsRedirection();
            app.UseMvc();
                          
        }
    }
}
