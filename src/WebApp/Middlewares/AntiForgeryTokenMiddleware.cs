using Microsoft.AspNetCore.Antiforgery;

namespace Uroskur.WebApp.Middlewares;

public class AntiForgeryTokenMiddleware
{
    private const string CsrfCookieName = "XSRF-TOKEN";
    private readonly IAntiforgery _antiforgery;
    private readonly RequestDelegate _next;

    public AntiForgeryTokenMiddleware(RequestDelegate next, IAntiforgery antiforgery)
    {
        _next = next;
        _antiforgery = antiforgery;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        var tokens = _antiforgery.GetAndStoreTokens(httpContext);
        if (tokens.RequestToken != null)
        {
            httpContext.Response.Cookies.Append(CsrfCookieName, tokens.RequestToken,
                new CookieOptions { HttpOnly = false });
        }

        await _next(httpContext);
    }
}