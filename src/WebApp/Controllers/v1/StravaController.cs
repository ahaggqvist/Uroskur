using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Uroskur.DataAccess.Repositories;
using Uroskur.WebApp.Models;
using Uroskur.WebApp.Services;

namespace Uroskur.WebApp.Controllers.v1;

[Route("api/v1/[controller]/[action]")]
[ApiController]
public class StravaController : ControllerBase
{
    private const string CallbackUuid = "cf547d74-db54-44d8-ad1a-83caa67c89ef";
    private readonly IGoogleUserRepository _googleUserRepository;
    private readonly ILogger<StravaController> _logger;
    private readonly IStravaService _stravaService;
    private readonly IStravaUserRepository _stravaUserRepository;

    public StravaController(IStravaService stravaService,
        IStravaUserRepository stravaUserRepository,
        IGoogleUserRepository googleUserRepository, ILogger<StravaController> logger)
    {
        _stravaService = stravaService;
        _stravaUserRepository = stravaUserRepository;
        _googleUserRepository = googleUserRepository;
        _logger = logger;
    }

    [HttpGet("{callbackUuid}")]
    [AllowAnonymous]
    public IActionResult SubscriptionCallback([FromRoute] string? callbackUuid, [FromQuery] SubscriptionModel subscriptionModel)
    {
        if (string.IsNullOrEmpty(callbackUuid) || !callbackUuid.Equals(callbackUuid))
        {
            return Unauthorized();
        }

        _logger.LogInformation("Subscription: {}.", subscriptionModel.ToString());

        return Ok($@"{{""hub.challenge"":""{subscriptionModel.HubChallenge}""}}");
    }

    [HttpPost("{callbackUuid}")]
    [AllowAnonymous]
    public async Task<IActionResult> SubscriptionCallbackAsync([FromRoute] string? callbackUuid, [FromBody] CallbackModel callbackModel)
    {
        if (string.IsNullOrEmpty(callbackUuid) || !callbackUuid.Equals(callbackUuid))
        {
            return Unauthorized();
        }

        var updates = callbackModel.Updates;
        if (updates is { Authorized: false })
        {
            var stravaUser = await _stravaUserRepository.FindByAthleteIdAsync(callbackModel.ObjectId);
            if (stravaUser != null)
            {
                _logger.LogInformation("Since authorized is: {} we deauthorization strava user with athlete ID {} and db ID {}.", updates.Authorized, stravaUser.AthleteId,
                    stravaUser.Id);

                var googleUser = await _googleUserRepository.FindByStravaUserIdAsync(stravaUser.Id);
                if (googleUser != null)
                {
                    googleUser.StravaUserId = null;

                    await _googleUserRepository.UpsertAsync(googleUser);

                    var success = _stravaUserRepository.RemoveAsync(stravaUser.Id);

                    _logger.LogInformation("Success: {}.", success);
                }
            }
        }

        _logger.LogInformation("Subscription callback: {}.", callbackModel.ToString());

        return Ok();
    }

    [HttpGet("{mail?}")]
    [AllowAnonymous]
    public async Task<IActionResult> TokenExchange([FromRoute] [FromQuery] TokenExchangeModel tokenExchangeModel)
    {
        if (string.IsNullOrEmpty(tokenExchangeModel.Mail) || string.IsNullOrEmpty(tokenExchangeModel.Code))
        {
            _logger.LogError("Token exchange failed because mail and code are invalid.");

            return Redirect("/settings");
        }

        var stravaUser = await _stravaService.TokenExchangeAsync(tokenExchangeModel.Code);
        if (stravaUser == null)
        {
            _logger.LogError("Token exchange failed beacuse strava user is null.");

            return Redirect("/settings");
        }

        var googleUser = await _googleUserRepository.FindByMailAsync(tokenExchangeModel.Mail);
        if (googleUser != null)
        {
            googleUser.StravaUserId = stravaUser.Id;
            await _googleUserRepository.UpsertAsync(googleUser);
        }

        return Redirect("/settings");
    }

    [HttpGet]
    public async Task<IActionResult> CreateSubscription()
    {
        return Ok(await _stravaService.CreateSubscriptionAsync());
    }

    [HttpGet]
    public async Task<IActionResult> ViewSubscription()
    {
        return Ok(await _stravaService.ViewSubscriptionAsync());
    }

    [HttpGet]
    public async Task<IActionResult> DeleteSubscription()
    {
        return Ok(await _stravaService.DeleteSubscriptionAsync());
    }

    [HttpGet]
    public async Task<IActionResult> Routes(long athleteId)
    {
        return Ok(await _stravaService.FindRoutesByAthleteIdAsync(athleteId));
    }

    [HttpGet]
    public async Task<IActionResult> StravaUserByAtleteId(long athleteId)
    {
        return Ok(await _stravaUserRepository.FindByAthleteIdAsync(athleteId));
    }
}