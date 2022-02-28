using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Uroskur.Shared.Models.TemperaturesHourly;

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
    public double? Uvi { get; set; }

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
    public double? Pop { get; set; }

    [JsonProperty("snow", NullValueHandling = NullValueHandling.Ignore)]
    public Rain? Snow { get; set; }

    [JsonProperty("rain", NullValueHandling = NullValueHandling.Ignore)]
    public Rain? Rain { get; set; }
}

public class Rain
{
    [JsonProperty("1h", NullValueHandling = NullValueHandling.Ignore)]
    public double? The1H { get; set; }
}

public class Weather
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; }

    [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
    public Main? Main { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; }
}

public enum Main
{
    Clear,
    Clouds,
    Rain,
    Snow
}

public partial class Temperatures
{
    public static Temperatures? FromJson(string json)
    {
        return JsonConvert.DeserializeObject<Temperatures>(json, Converter.Settings);
    }
}

public static class Serialize
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
            MainConverter.Singleton,
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        }
    };
}

internal class MainConverter : JsonConverter
{
    public static readonly MainConverter Singleton = new();

    public override bool CanConvert(Type t)
    {
        return t == typeof(Main) || t == typeof(Main?);
    }

    public override object? ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
        {
            return null;
        }

        var value = serializer.Deserialize<string>(reader);
        return value switch
        {
            "Clear" => Main.Clear,
            "Clouds" => Main.Clouds,
            "Rain" => Main.Rain,
            "Snow" => Main.Snow,
            _ => throw new Exception("Cannot unmarshal type Main")
        };
    }

    public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }

        var value = (Main)untypedValue;
        switch (value)
        {
            case Main.Clear:
                serializer.Serialize(writer, "Clear");
                return;
            case Main.Clouds:
                serializer.Serialize(writer, "Clouds");
                return;
            case Main.Rain:
                serializer.Serialize(writer, "Rain");
                return;
            case Main.Snow:
                serializer.Serialize(writer, "Snow");
                return;
            default:
                throw new Exception("Cannot marshal type Main");
        }
    }
}