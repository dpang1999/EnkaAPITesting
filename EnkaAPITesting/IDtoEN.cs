using System.Text.Json;

namespace EnkaAPITesting;

public class IDtoEN
{
    private Dictionary<string, JsonElement> charsByID;
    private Dictionary<string, string> en;
    public IDtoEN(Dictionary<string, JsonElement> charsByID, Dictionary<string, string> en)
    {
        this.charsByID = charsByID;
        this.en = en;
    }

    public string charEN(string avatarID)
    {
        Characters character = JsonSerializer.Deserialize<Characters>(charsByID[avatarID+""]);
        return en[character.NameTextMapHash+""];
    }

    public string idEN(string ID)
    {
        return en[ID + ""];
    }
}