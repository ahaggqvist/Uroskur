using Newtonsoft.Json;

namespace Uroskur.WebApp.Models;

public class EventModel
{
    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; }

    [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
    public string? Private { get; set; }

    [JsonProperty("authorized", NullValueHandling = NullValueHandling.Ignore)]
    public bool Authorized { get; set; } = true;

    public override string ToString()
    {
        return $"{nameof(Title)}: {Title}, {nameof(Type)}: {Type}, {nameof(Private)}: {Private}, {nameof(Authorized)}: {Authorized}";
    }
}