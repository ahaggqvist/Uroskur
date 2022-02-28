using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using NeoSmart.Caching.Sqlite;
using Uroskur.DataAccess;
using Uroskur.Shared.Models;
using Uroskur.WebApp.Extensions;
using Uroskur.WebApp.Services;

namespace Uroskur.WebApp;

public class Startup
{
    private const string CsrfHeaderName = "X-XSRF-TOKEN";
    private const string RootPath = "ClientApp/build";
    private const string GoogleCallbackPath = "/signin-google";
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DataContext>(optionsBuilder =>
        {
            //optionsBuilder.LogTo(message => Debug.WriteLine(message));
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
        });

        var appSettings = new AppSettings();
        _configuration.GetSection("AppSettings").Bind(appSettings);
        services.AddSingleton(appSettings);

        services.AddHttpClient();

        services.AddMisc().AddStrava().AddOpenWeather().AddSetting();

        services.AddSqliteCache(options =>
        {
            options.CachePath = _configuration["Cache:CachePath"];
        });

        services.AddSpaStaticFiles(options =>
        {
            options.RootPath = RootPath;
        });

        services.AddAntiforgery(options =>
        {
            options.HeaderName = CsrfHeaderName;
        });

        services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityConstants.ExternalScheme;
                options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            })
            .AddCookie(IdentityConstants.ExternalScheme, options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.SameSite = SameSiteMode.Strict;
                options.Cookie.MaxAge = TimeSpan.FromDays(1);
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            })
            .AddGoogle(options =>
            {
                options.ClientId = _configuration["Authentication:Google:ClientId"];
                options.ClientSecret = _configuration["Authentication:Google:ClientSecret"];
                options.SignInScheme = IdentityConstants.ExternalScheme;
                options.CallbackPath = new PathString(GoogleCallbackPath);
                options.Events.OnCreatingTicket += async context =>
                {
                    var claimService = context.HttpContext.RequestServices.GetRequiredService<IClaimService>();
                    await claimService.AddMailClaimAsync(context);
                };
            });

        services.AddControllers(options =>
        {
            options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build()));
        }).AddNewtonsoftJson();
    }


    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseSpaStaticFiles();

        app.UseAntiForgery();

        app.UseAuthentication();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseSpaStaticFiles();

        app.UseSpa(config =>
        {
            config.Options.SourcePath = "ClientApp";

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                config.UseProxyToSpaDevelopmentServer("https://localhost:3000");
            }
        });
    }
}