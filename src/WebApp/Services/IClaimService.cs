using Microsoft.AspNetCore.Authentication.OAuth;

namespace Uroskur.WebApp.Services;

public interface IClaimService
{
    Task AddMailClaimAsync(OAuthCreatingTicketContext context);
}