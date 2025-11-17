namespace CS2Cheat.Utils.ClientDllDto;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Cak47
{
    [JsonProperty("fields")]
    [JsonPropertyName("fields")]
    public Fields? Fields
    {
        get;
        set;
    }

    [JsonProperty("metadata")]
    [JsonPropertyName("metadata")]
    public List<object> Metadata
    {
        get;
        set;
    } = [];

    [JsonProperty("parent")]
    [JsonPropertyName("parent")]
    public string? Parent
    {
        get;
        set;
    }
}
