using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Uroskur.WebApp.Models;

public class CallbackModel
{
    [JsonProperty("aspect_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? AspectType { get; set; }

    [JsonProperty("event_time", NullValueHandling = NullValueHandling.Ignore)]
    public long EventTime { get; set; }

    [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
    public long ObjectId { get; set; }

    [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
    public string? ObjectType { get; set; }

    [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
    public long OwnerId { get; set; }

    [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
    public long SubscriptionId { get; set; }

    [JsonPropertyName("updates")] public EventModel? Updates { get; set; }


    public override string ToString()
    {
        return
            $"{nameof(AspectType)}: {AspectType}, {nameof(EventTime)}: {EventTime}, {nameof(ObjectId)}: {ObjectId}, {nameof(ObjectType)}: {ObjectType}, {nameof(OwnerId)}: {OwnerId}, {nameof(SubscriptionId)}: {SubscriptionId}, {nameof(Updates)}: {Updates}";
    }
}