using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace HrmRecruitingProj.Utility
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareExtension
    {
        private readonly RequestDelegate _next;

        public MiddlewareExtension(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);

            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }

        }
        public async Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await httpContext.Response.WriteAsync("Status Code = " + httpContext.Response.StatusCode+ "");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensionExtensions
    {
        public static IApplicationBuilder UseMiddlewareExtension(this IApplicationBuilder builder)
        {
            var app = builder.Build();
            return builder.UseMiddleware<MiddlewareExtension>();
        }
    }
}
