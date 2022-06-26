using Microsoft.AspNetCore.Builder;
namespace MyFirstApp
{
    public static class MyMiddlewareExtension
    {
        // Extention  method
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware>();
        }
    }
}