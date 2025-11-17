using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CS2Cheat.Utils.ClientDllDto;

public class AudioparamsT
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
    public List<Metadata> Metadata
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
