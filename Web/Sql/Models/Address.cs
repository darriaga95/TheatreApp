using System.Text.Json.Serialization;

namespace Web.Sql.Models;
public sealed record Address : IProperty<Address>
{
    [JsonPropertyName("street")]
    public string Street { get; init; } = "";

    [JsonPropertyName("unit")]
    public string Unit { get; init; } = "";

    [JsonPropertyName("city")]
    public string City { get; init; } = "";

    [JsonPropertyName("state")]
    public string State { get; init; } = "";

    [JsonPropertyName("zipcode")]
    public string ZipCode { get; init; } = "";
}