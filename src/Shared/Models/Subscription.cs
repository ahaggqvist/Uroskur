using Newtonsoft.Json;
using Uroskur.Shared.Models.TemperaturesCurrent;

namespace Uroskur.Shared.Models;

public partial class Subscription
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("resource_state", NullValueHandling = NullValueHandling.Ignore)]
    public long? ResourceState { get; set; }

    [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
    public long? ApplicationId { get; set; }

    [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
    public string? CallbackUrl { get; set; }

    [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedAt { get; set; }
}

public partial class Subscription
{
    public static List<Subscription>? FromJson(string json)
    {
        return JsonConvert.DeserializeObject<List<Subscription>>(json, Converter.Settings);
    }
}

public static class Serialize
{
    public static string ToJson(this List<Subscription> self)
    {
        return JsonConvert.SerializeObject(self, Converter.Settings);
    }
}