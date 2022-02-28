using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Uroskur.Shared.Models.TemperaturesCurrent;

public partial class Temperatures
{
    [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Lat { get; set; }

    [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
    public double? Lon { get; set; }

    [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezone { get; set; }

    [JsonProperty("timezone_offset", NullValueHandling = NullValueHandling.Ignore)]
    public long? TimezoneOffset { get; set; }

    [JsonProperty("hourly", NullValueHandling = NullValueHandling.Ignore)]
    public List<Hourly>? Hourly { get; set; }

    [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
    public Hourly? Current { get; set; }
}

public class Hourly
{
    [JsonProperty("dt", NullValueHandling = NullValueHandling.Ignore)]
    public long? Dt { get; set; }

    [JsonProperty("temp", NullValueHandling = NullValueHandling.Ignore)]
    public double? Temp { get; set; }

    [JsonProperty("feels_like", NullValueHandling = NullValueHandling.Ignore)]
    public double? FeelsLike { get; set; }

    [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
    public long? Pressure { get; set; }

    [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
    public long? Humidity { get; set; }

    [JsonProperty("dew_point", NullValueHandling = NullValueHandling.Ignore)]
    public double? DewPoint { get; set; }

    [JsonProperty("uvi", NullValueHandling = NullValueHandling.Ignore)]
    public long? Uvi { get; set; }

    [JsonProperty("clouds", NullValueHandling = NullValueHandling.Ignore)]
    public long? Clouds { get; set; }

    [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
    public long? Visibility { get; set; }

    [JsonProperty("wind_speed", NullValueHandling = NullValueHandling.Ignore)]
    public double? WindSpeed { get; set; }

    [JsonProperty("wind_deg", NullValueHandling = NullValueHandling.Ignore)]
    public long? WindDeg { get; set; }

    [JsonProperty("wind_gust", NullValueHandling = NullValueHandling.Ignore)]
    public double? WindGust { get; set; }

    [JsonProperty("weather", NullValueHandling = NullValueHandling.Ignore)]
    public List<Weather>? Weather { get; set; }

    [JsonProperty("pop", NullValueHandling = NullValueHandling.Ignore)]
    public long? Pop { get; set; }
}

public class Weather
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
    public string? Main { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; }
}

public partial class Temperatures
{
    public static Temperatures? FromJson(string json)
    {
        return JsonConvert.DeserializeObject<Temperatures>(json, Converter.Settings);
    }
}

public static class SerializeTemperatures
{
    public static string ToJson(this Temperatures self)
    {
        return JsonConvert.SerializeObject(self, Converter.Settings);
    }
}

internal static class Converter
{
    public static readonly JsonSerializerSettings? Settings = new()
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        }
    };
}