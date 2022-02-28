using Newtonsoft.Json;
using Uroskur.Shared.Models.TemperaturesCurrent;

namespace Uroskur.Shared.Models;

public partial class Routes
{
    [JsonProperty("athlete", NullValueHandling = NullValueHandling.Ignore)]
    public Athlete? Athlete { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
    public double? Distance { get; set; }

    [JsonProperty("elevation_gain", NullValueHandling = NullValueHandling.Ignore)]
    public double? ElevationGain { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("id_str", NullValueHandling = NullValueHandling.Ignore)]
    public string? IdStr { get; set; }

    [JsonProperty("map", NullValueHandling = NullValueHandling.Ignore)]
    public Map? Map { get; set; }

    [JsonProperty("map_urls", NullValueHandling = NullValueHandling.Ignore)]
    public MapUrls? MapUrls { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Private { get; set; }

    [JsonProperty("resource_state", NullValueHandling = NullValueHandling.Ignore)]
    public long? ResourceState { get; set; }

    [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Starred { get; set; }

    [JsonProperty("sub_type", NullValueHandling = NullValueHandling.Ignore)]
    public long? SubType { get; set; }

    [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedAt { get; set; }

    [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdatedAt { get; set; }

    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public long? Timestamp { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public long? Type { get; set; }

    [JsonProperty("estimated_moving_time", NullValueHandling = NullValueHandling.Ignore)]
    public long? EstimatedMovingTime { get; set; }
}

public class Map
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; }

    [JsonProperty("summary_polyline", NullValueHandling = NullValueHandling.Ignore)]
    public string? SummaryPolyline { get; set; }

    [JsonProperty("resource_state", NullValueHandling = NullValueHandling.Ignore)]
    public long? ResourceState { get; set; }
}

public class MapUrls
{
    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; }

    [JsonProperty("retina_url", NullValueHandling = NullValueHandling.Ignore)]
    public string? RetinaUrl { get; set; }
}

public partial class Routes
{
    public static List<Routes>? FromJson(string json)
    {
        return JsonConvert.DeserializeObject<List<Routes>>(json, Converter.Settings);
    }
}

public static class SerializeRoutes
{
    public static string ToJson(this List<Routes> self)
    {
        return JsonConvert.SerializeObject(self, Converter.Settings);
    }
}