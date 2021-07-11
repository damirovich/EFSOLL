using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _002Task2ASP
{
    public class Startup
    {
       
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //Инициализация класса Company
            Company company = new Company();
            company.Id = 1;
            company.Name = "Microsoft";
            Company company1 = new Company();
            company1.Id = 2;
            company1.Name = "Google";

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //Вывод информации о компании
                    await context.Response.WriteAsync($"Information about the company\n" +
                        $"Id:{company.Id}\n" +
                        $"Company Name: {company.Name}\n" +
                        $"Id:{company1.Id}\n" +
                        $"Company Name: {company1.Name}");
                    
                });
            });
        }
    }
}
