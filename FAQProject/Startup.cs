using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FAQProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(Options =>
            {
                Options.LowercaseUrls = true;
                Options.AppendTrailingSlash = true;
            });

            services.AddControllersWithViews();

            services.AddDbContext<FAQContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("FAQContext")));

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "category",
                    pattern: "{controller=Home}/{action=Index}/topic/{topic}/category/{category}");
                endpoints.MapControllerRoute(
                    name: "topic",
                    pattern: "{controller=Home}/{action=Index}/topic/{topic}");
                endpoints.MapControllerRoute(
                    name: "topic",
                    pattern: "{controller=Home}/{action=Index}/category/{category}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
