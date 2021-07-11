using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004Task1ASP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Сервис маршрутизации
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var routebuilder = new RouteBuilder(app);
            routebuilder.MapRoute("{controller}/{action}/{id}",
               async context =>
               {
                   RouteData routeData = context.GetRouteData();
                   foreach (var item in routeData.Values) {
                       await context.Response.WriteAsync($"<br>{item.ToString()}</br>");
                   }
               });

            //routebuilder.MapRoute("{controller}/{action}/{id}",
            //    async context =>
            //    {
            //        string controller = context.GetRouteValue("controller").ToString();
            //        string action = context.GetRouteValue("action").ToString();
            //        string id = context.GetRouteValue("id").ToString();
            //        await context.Response.WriteAsync($"<p>{controller}</p><p>{action}</p><p>{id}</p>");
            //    });
         
            app.UseRouter(routebuilder.Build());
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Default page");
            });
        }
    }
}
