using Newtonsoft.Json;

namespace Uroskur.WebApp.Models;

public class UserModel
{
    [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; }

    public string? Mail { get; set; }

    [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; }

    [JsonProperty("athlete_id", NullValueHandling = NullValueHandling.Ignore)]
    public long? AthleteId { get; set; }

    public string? Locale { get; set; } = "en";

    public string? Timezone { get; set; } = "Europe/Amsterdam";
}