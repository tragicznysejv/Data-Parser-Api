using System.Text.Json.Serialization;

namespace ParserDanychApi.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LoadType
    {
        CSV,
        INTERNAL_JSON
    }
}
