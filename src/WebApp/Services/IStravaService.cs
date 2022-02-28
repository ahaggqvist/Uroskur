using Uroskur.Model;
using Uroskur.Shared.Models;

namespace Uroskur.WebApp.Services;

public interface IStravaService
{
    Task<StravaUser?> TokenExchangeAsync(string code);

    Task<string?> CreateSubscriptionAsync();

    Task<bool?> DeleteSubscriptionAsync();

    Task<Subscription?> ViewSubscriptionAsync();

    Task<IEnumerable<Routes>> FindRoutesByAthleteIdAsync(long athleteId);

    Task<IEnumerable<Location>> FindLocationsByAthleteIdRouteIdAsync(long athleteId, long routeId);
}