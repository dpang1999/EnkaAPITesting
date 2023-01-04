using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Reflection;
using System.Text.Json.Serialization;
using EnkaAPITesting;


using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessRepositoriesAsync(client);
//Console.WriteLine(enkaData.ToString());
/*foreach (var player in repositories)
{
    Console.WriteLine($"Name: {player.Name}");
    Console.WriteLine($"Signature: {player.Signature}");
    Console.WriteLine($"World Level: {player.WorldLevel}");
    Console.WriteLine($"PFP ID: {player.ProfilePicture}");
    Console.WriteLine();
}*/
//https://enka.network/u/603279592/__data.json"

static async Task ProcessRepositoriesAsync(HttpClient client)
{
    await using Stream json = await client.GetStreamAsync("https://enka.network/u/603279592/__data.json");
    EnkaData data = await JsonSerializer.DeserializeAsync<EnkaData>(json);
   
   await using Stream loc =  await client.GetStreamAsync(
        "https://raw.githubusercontent.com/EnkaNetwork/API-docs/master/store/loc.json");
    Dictionary<string, JsonElement> localizations = await JsonSerializer.DeserializeAsync<Dictionary<string, JsonElement>>(loc);
    JsonElement engLoc = localizations["en"];
    Dictionary<string, string> eng = JsonSerializer.Deserialize<Dictionary<string, string>>(engLoc);

    await using Stream chars = await client.GetStreamAsync(
        "https://raw.githubusercontent.com/EnkaNetwork/API-docs/master/store/characters.json");
    Dictionary<string, JsonElement> charsByID = await JsonSerializer.DeserializeAsync<Dictionary<string, JsonElement>>(chars);
    

    IDtoEN english = new IDtoEN(charsByID, eng);
    foreach (var item in data.avatarInfoList)
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(english.charEN(item.avatarId+""));
        Console.WriteLine(item.fightPropMap);
    }
}