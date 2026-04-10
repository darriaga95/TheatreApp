using System.Text.Json.Serialization;

namespace Web.Sql.Models;
public sealed record Name : IProperty<Name>
{
    [JsonPropertyName("first")]
    public string First { get; set; } = "";

    [JsonPropertyName("middle")]
    public string Middle { get; set; } = "";

    [JsonPropertyName("last")]
    public string Last { get; set; } = "";
}