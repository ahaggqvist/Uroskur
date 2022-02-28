using Microsoft.AspNetCore.Antiforgery;

namespace Uroskur.WebApp.Middlewares;

public class ValidateAntiForgeryTokenMiddleware
{
    private readonly IAntiforgery _antiforgery;
    private readonly RequestDelegate _next;

    public ValidateAntiForgeryTokenMiddleware(RequestDelegate next, IAntiforgery antiforgery)
    {
        _next = next;
        _antiforgery = antiforgery;
    }

    public async Task Invoke(HttpContext context)
    {
        if (HttpMethods.IsPost(context.Request.Method) && !context.Request.Path.StartsWithSegments("/api/v1/Strava"))
        {
            await _antiforgery.ValidateRequestAsync(context);
        }

        await _next(context);
    }
}