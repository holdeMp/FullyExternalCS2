namespace CS2Cheat.Utils.ClientDllDto;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class CcsGameModeRulesDeathmatch
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
    public object? Parent
    {
        get;
        set;
    }
}
