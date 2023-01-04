// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;
public record Characters(
    [property: JsonPropertyName("Element")] string Element,
    //[property: JsonPropertyName("Consts")] IReadOnlyList<string> Consts,
    //[property: JsonPropertyName("SkillOrder")] IReadOnlyList<int> SkillOrder,
    [property: JsonPropertyName("NameTextMapHash")] long NameTextMapHash
    //[property: JsonPropertyName("SideIconName")] string SideIconName,
    //[property: JsonPropertyName("QualityType")] string QualityType
);
    