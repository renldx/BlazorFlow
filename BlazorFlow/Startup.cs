using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using BlazorFlow.Data;
using BlazorFlow.Services;
using AutoMapper;

namespace BlazorFlow {
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddTransient<IFlowService, FlowService>();
            services.AddTransient<IUserFlowService, UserFlowService>();
            services.AddTransient<ILookupService, LookupService>();

            services.AddDbContext<FlowContext>(options =>
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                string connectString;

                if (env == "Development")
                {
                    connectString = Configuration.GetConnectionString("PostgreSQL");
                }
                else
                {
                    var connectUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

                    if (connectUrl is null) { throw new Exception("DATABASE_URL is null"); }

                    connectUrl = connectUrl.Replace("postgres://", string.Empty);
                    var pgUserPass = connectUrl.Split("@")[0];
                    var pgHostPortDb = connectUrl.Split("@")[1];
                    var pgHostPort = pgHostPortDb.Split("/")[0];
                    var pgDb = pgHostPortDb.Split("/")[1];
                    var pgUser = pgUserPass.Split(":")[0];
                    var pgPass = pgUserPass.Split(":")[1];
                    var pgHost = pgHostPort.Split(":")[0];
                    var pgPort = pgHostPort.Split(":")[1];

                    connectString = $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb}";
                }

                options.UseNpgsql(connectString);
            },

            ServiceLifetime.Transient);
        
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews(); // Not sure if needed
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
