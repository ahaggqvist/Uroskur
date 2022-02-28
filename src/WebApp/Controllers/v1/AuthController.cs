using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Uroskur.DataAccess.Repositories;
using Uroskur.WebApp.Models;

namespace Uroskur.WebApp.Controllers.v1;

[Route("api/v1/[controller]/[action]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IGoogleUserRepository _googleUserRepository;
    private readonly ILogger<AuthController> _logger;
    private readonly ISettingRespository _settingRespository;
    private readonly IStravaUserRepository _stravaUserRepository;

    public AuthController(IGoogleUserRepository googleUserRepository,
        IStravaUserRepository stravaUserRepository, ISettingRespository settingRespository, ILogger<AuthController> logger)
    {
        _googleUserRepository = googleUserRepository;
        _stravaUserRepository = stravaUserRepository;
        _settingRespository = settingRespository;
        _logger = logger;
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login()
    {
        return new ChallengeResult(
            GoogleDefaults.AuthenticationScheme,
            new AuthenticationProperties
            {
                RedirectUri = Url.Action(nameof(LoginCallback), "Auth")
            });
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult LoginCallback()
    {
        return Redirect("/");
    }

    [HttpPost]
    public async Task Logout()
    {
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> UserInfo()
    {
        // We disable initial automatic challenge by setting [AllowAnonymous] and return 401 if unauthorized.
        if (!User.HasClaim(c => c.Type == ClaimTypes.Email))
        {
            _logger.LogError("Mail claim is invalid.");

            return Unauthorized();
        }

        var mail = User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Email)?.Value;
        var googleUser = await _googleUserRepository.FindByMailAsync(mail);
        var setting = await _settingRespository.FindAsync(0);

        var userModel = new UserModel
        {
            DisplayName = googleUser?.DisplayName,
            Mail = googleUser?.Mail,
            ClientId = setting?.ClientId
        };

        var stravaUserId = googleUser?.StravaUserId;
        if (stravaUserId != null)
        {
            var stravaUser = await _stravaUserRepository.FindAsync((long)stravaUserId);
            userModel.AthleteId = stravaUser?.AthleteId;
        }

        return Ok(userModel);
    }
}