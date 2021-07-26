using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _002ASPAdvancedTask2
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;
        SendFile file = new SendFile();
        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
             string path = context.Request.Path;
             string pathBase = context.Request.PathBase;
             await context.Response.WriteAsync($"Main branch. Path: {path}, PathBase: {pathBase}");
             file.Send(path, pathBase);
        }
    }
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMy(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyMiddleware>();
           
        }
    }
}

