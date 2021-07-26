using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _002ASPAdvancedTask1
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;
        private short i = 0; // счетчик запросов
        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //В браузере Google Chrome и Microsoft Edge колличество запросов будет увеличевоться по 2 раза
            //так как кроме стандартного запросу к серверу еще производиться запрос к иконке

            //В браузере Internet Exploler колличество запросов будет увеличевоться по 1 раза
            i++;
            context.Response.ContentType = "text/html;charset=utf-8";
            await context.Response.WriteAsync($"Запрос {i}");
            
        }

    }
    public static class MiddlewareExtensions
    {
        // Расширяющий метод для подключение middleware к pipline
        public static IApplicationBuilder UseMy(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyMiddleware>();
        }
    }
}
