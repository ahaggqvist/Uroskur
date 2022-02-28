using Uroskur.Shared.Models;

namespace Uroskur.Shared;

public interface IStravaClient
{
    Task<AuthorizationToken?> GetAuthorizationTokenAsync(string? code, string? clientId, string? clientSecret);

    Task<string?> CreateSubscriptionAsync(string? clientId, string? clientSecret);

    Task<bool?> DeleteSubscriptionAsync(string? clientId, string? clientSecret);

    Task<Subscription?> ViewSubscriptionAsync(string? clientId, string? clientSecret);

    Task<AuthorizationToken?> GetRefreshTokenAsync(string? refreshToken, string? clientId,
        string? clientSecret);

    Task<IEnumerable<Routes>> GetRoutesAsync(long athleteId, string? authorizationToken);

    Task<string> GetGxpAsync(long routeId, string? authorizationToken);
}