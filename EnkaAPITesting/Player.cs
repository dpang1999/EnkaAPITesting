namespace EnkaAPITesting;

using System.Text.Json.Serialization;

public record class Player(
    [property: JsonPropertyName("nickname")] string Name,
    [property: JsonPropertyName("signature")] string Signature,
    [property: JsonPropertyName("worldLevel")] int WorldLevel,
    [property: JsonPropertyName("profilePicture.avatarId")] long ProfilePicture);