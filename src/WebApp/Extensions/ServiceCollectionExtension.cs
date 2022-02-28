using Uroskur.DataAccess.Repositories;
using Uroskur.Shared;
using Uroskur.Shared.Models;
using Uroskur.WebApp.Services;

namespace Uroskur.WebApp.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddStrava(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        serviceCollection.AddScoped<IStravaClient>(provider => new StravaClient(provider.GetService<AppSettings>(),
            provider.GetRequiredService<IHttpClientFactory>().CreateClient()));

        serviceCollection.AddScoped<IStravaService, StravaService>();

        serviceCollection.AddScoped<IStravaUserRepository, StravaUserRepository>();

        return serviceCollection;
    }

    public static IServiceCollection AddOpenWeather(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IOpenWeatherClient>(provider =>
            new OpenWeatherClient(provider.GetService<AppSettings>(),
                provider.GetRequiredService<IHttpClientFactory>().CreateClient()));

        serviceCollection.AddScoped<IOpenWeatherService, OpenWeatherService>();

        return serviceCollection;
    }

    public static IServiceCollection AddSetting(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ISettingRespository, SettingRepository>();

        return serviceCollection;
    }

    public static IServiceCollection AddMisc(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IGoogleUserRepository, GoogleUserRepository>();

        serviceCollection.AddScoped<IClaimService, ClaimService>();

        return serviceCollection;
    }
}