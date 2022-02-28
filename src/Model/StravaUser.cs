using System.ComponentModel.DataAnnotations.Schema;

namespace Uroskur.Model;

[Table("strava_users")]
public sealed class StravaUser : BaseModel
{
    public long? AthleteId { get; init; }

    public string? Username { get; init; }

    public string? Firstname { get; init; }

    public string? Lastname { get; init; }

    public string? RefreshToken { get; set; }

    public string? AccessToken { get; set; }

    public long? ExpiresAt { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(AthleteId)}: {AthleteId}, {nameof(Username)}: {Username}, {nameof(Firstname)}: {Firstname}, {nameof(Lastname)}: {Lastname}, {nameof(RefreshToken)}: {RefreshToken}, {nameof(AccessToken)}: {AccessToken}, {nameof(ExpiresAt)}: {ExpiresAt}";
    }
}