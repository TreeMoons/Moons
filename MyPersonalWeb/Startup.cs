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
using ModelsLibrary.Languages;
using Microsoft.AspNetCore.Http.Features;

namespace MyPersonalWeb
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
            services.AddControllersWithViews();
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(10d);
                option.Cookie.IsEssential = true;
                option.Cookie.HttpOnly = true;
            });
            services.AddCors(op => {
                op.AddPolicy(name:"_myCorsSpecificOrigins",
                biuld =>
                {
                    // biuld.AllowAnyOrigin();
                    // biuld.WithOrigins("https://127.0.0.1");
                });
            });
            services.AddControllers();
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
                app.UseExceptionHandler("/EN/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                        name: "MyAreaAdmin",
                        areaName: "Admin",
                        pattern: "{language?}/admin/{controller=home}/{action=index}/{id?}",
                        constraints: Utils.AreaAdminLanguagesParttern.Length == 0 ? null : new { language = Utils.AreaAdminLanguagesParttern.ToString() }
                        );

                endpoints.MapAreaControllerRoute(
                        name: "MyAreaAPI",
                        areaName: "API",
                        pattern: "api/{controller=home}/{action=index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{language?}/{controller=home}/{action=index}/{id?}",
                    constraints: new { language = Utils.LanguagesParterrn.ToString() } //new {pattern=@"正则表达式"}
                    );
                // endpoints.MapControllers().RequireCors("_myCorsSpecificOrigins");
            });
        }
    }
}
