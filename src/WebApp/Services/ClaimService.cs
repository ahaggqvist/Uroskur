using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.OAuth;
using Uroskur.DataAccess.Repositories;
using Uroskur.Model;

namespace Uroskur.WebApp.Services;

public class ClaimService : IClaimService
{
    private readonly IGoogleUserRepository _googleUserRepository;
    private readonly ILogger<ClaimService> _logger;

    public ClaimService(IGoogleUserRepository googleUserRepository, ILogger<ClaimService> logger)
    {
        _googleUserRepository = googleUserRepository;
        _logger = logger;
    }


    public async Task AddMailClaimAsync(OAuthCreatingTicketContext context)
    {
        var displayName = context.Identity?.Name;
        var mail = context.Identity?.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Email)?.Value;
        if (string.IsNullOrEmpty(mail))
        {
            _logger.LogError("Mail claim is blank.");

            return;
        }

        var googleUser = await _googleUserRepository.FindByMailAsync(mail);
        if (googleUser == null)
        {
            await _googleUserRepository.AddAsync(new GoogleUser
            {
                DisplayName = displayName,
                Mail = mail
            });
        }

        _logger.LogInformation("Google user with displayName: {} and mail: {}.", displayName,
            mail);
    }
}