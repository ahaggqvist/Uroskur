using Uroskur.WebApp.Middlewares;

namespace Uroskur.WebApp.Extensions;

public static class AntiForgeryExtension
{
    public static IApplicationBuilder UseAntiForgery(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ValidateAntiForgeryTokenMiddleware>().UseMiddleware<AntiForgeryTokenMiddleware>();
    }
}