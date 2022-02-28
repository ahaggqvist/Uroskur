using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Uroskur.WebApp.Models;

public class SubscriptionModel
{
    [FromQuery(Name = "hub.verify_token")]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? VerifyToken { get; set; }

    [FromQuery(Name = "hub.challenge")]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? HubChallenge { get; set; }

    [FromQuery(Name = "hub.mode")]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? HubMode { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(VerifyToken)}: {VerifyToken}, {nameof(HubChallenge)}: {HubChallenge}, {nameof(HubMode)}: {HubMode}";
    }
}