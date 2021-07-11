using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace _003Task1ASP
{
    public class Startup
    {
        // Свойство, хранящее набор значений конфигурации приложения
        public IConfiguration AppConfiguration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Создаем экземпляр класса строителя конфигурации
            var builder = new ConfigurationBuilder();

            // Устанавливаем путь, по которому будет производится поиск файла конфигурации
            builder.SetBasePath(env.ContentRootPath);

            // Задаем имя используемого файла конфигурации
            builder.AddJsonFile("appsettings.json");

            // Создаем конфигурацию
            AppConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            IConfigurationSection section = AppConfiguration.GetSection("address");
            string streetAddress = section.GetSection("streetAddress").Value;
            string city = section.GetSection("city").Value;
            string state = section.GetSection("state").Value;
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<p>{AppConfiguration["name"]}</p>" +
                    $"<p>{AppConfiguration["email"]}</p>" +
                    $"<p>{AppConfiguration["Age"]}</p>" +
                    $"<br>My Address</br>" +
                    $"<br>Street Address: {streetAddress}</br>" +
                    $"<br>City: {city}</br>" +
                    $"<br>State: {state}</br>");
            });
        }
    }
}
