using Newtonsoft.Json;
using Uroskur.Shared.Models.TemperaturesCurrent;

namespace Uroskur.Shared.Models;

public partial class AuthorizationToken
{
    [JsonProperty("token_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? TokenType { get; set; }

    [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
    public long? ExpiresAt { get; set; }

    [JsonProperty("expires_in", NullValueHandling = NullValueHandling.Ignore)]
    public long? ExpiresIn { get; set; }

    [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
    public string? RefreshToken { get; set; }

    [JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
    public string? AccessToken { get; set; }

    [JsonProperty("athlete", NullValueHandling = NullValueHandling.Ignore)]
    public Athlete? Athlete { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(TokenType)}: {TokenType}, {nameof(ExpiresAt)}: {ExpiresAt}, {nameof(ExpiresIn)}: {ExpiresIn}, {nameof(RefreshToken)}: {RefreshToken}, {nameof(AccessToken)}: {AccessToken}, {nameof(Athlete)}: {Athlete}";
    }
}

public class Athlete
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; }

    [JsonProperty("resource_state", NullValueHandling = NullValueHandling.Ignore)]
    public long? ResourceState { get; set; }

    [JsonProperty("firstname", NullValueHandling = NullValueHandling.Ignore)]
    public string? Firstname { get; set; }

    [JsonProperty("lastname", NullValueHandling = NullValueHandling.Ignore)]
    public string? Lastname { get; set; }

    [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; }

    [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
    public string? State { get; set; }

    [JsonProperty("country")] public object? Country { get; set; }

    [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
    public string? Sex { get; set; }

    [JsonProperty("premium", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Premium { get; set; }

    [JsonProperty("summit", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Summit { get; set; }

    [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonProperty("badge_type_id", NullValueHandling = NullValueHandling.Ignore)]
    public long? BadgeTypeId { get; set; }

    [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
    public long? Weight { get; set; }

    [JsonProperty("profile_medium", NullValueHandling = NullValueHandling.Ignore)]
    public string? ProfileMedium { get; set; }

    [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
    public string? Profile { get; set; }

    [JsonProperty("friend")] public object? Friend { get; set; }

    [JsonProperty("follower")] public object? Follower { get; set; }
}

public partial class AuthorizationToken
{
    public static AuthorizationToken? FromJson(string json)
    {
        return JsonConvert.DeserializeObject<AuthorizationToken>(json, Converter.Settings);
    }
}