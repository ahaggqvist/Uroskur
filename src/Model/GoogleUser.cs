using System.ComponentModel.DataAnnotations.Schema;

namespace Uroskur.Model;

[Table("google_users")]
public sealed class GoogleUser : BaseModel
{
    public string? DisplayName { get; set; }
    public string? Mail { get; set; }

    public int? StravaUserId { get; set; }

    public StravaUser? StravaUser { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(DisplayName)}: {DisplayName}, {nameof(Mail)}: {Mail}, {nameof(StravaUserId)}: {StravaUserId}, {nameof(StravaUser)}: {StravaUser}";
    }
}