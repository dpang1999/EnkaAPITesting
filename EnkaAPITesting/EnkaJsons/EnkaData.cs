// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

using System.Text.Json.Serialization;

public record _1001(
        [property: JsonPropertyName("type")] int type,
        [property: JsonPropertyName("ival")] string ival,
        [property: JsonPropertyName("val")] string val
    );

    public record _10010(
        [property: JsonPropertyName("type")] int type,
        [property: JsonPropertyName("ival")] string ival,
        [property: JsonPropertyName("val")] string val
    );

    public record _1002(
        [property: JsonPropertyName("type")] int type,
        [property: JsonPropertyName("ival")] string ival,
        [property: JsonPropertyName("val")] string val
    );

    public record _1003(
        [property: JsonPropertyName("type")] int type,
        [property: JsonPropertyName("ival")] string ival
    );

    public record _1004(
        [property: JsonPropertyName("type")] int type,
        [property: JsonPropertyName("ival")] string ival
    );

    public record _4001(
        [property: JsonPropertyName("type")] int type,
        [property: JsonPropertyName("ival")] string ival,
        [property: JsonPropertyName("val")] string val
    );

    public record AffixMap(
        [property: JsonPropertyName("115502")] int _115502,
        [property: JsonPropertyName("115401")] int? _115401,
        [property: JsonPropertyName("115405")] int? _115405,
        [property: JsonPropertyName("114302")] int? _114302,
        [property: JsonPropertyName("114509")] int? _114509,
        [property: JsonPropertyName("113415")] int? _113415,
        [property: JsonPropertyName("111505")] int? _111505,
        [property: JsonPropertyName("115402")] int? _115402
    );

    public record AvatarInfoList(
        [property: JsonPropertyName("avatarId")] int avatarId,
        [property: JsonPropertyName("propMap")] PropMap propMap,
        [property: JsonPropertyName("talentIdList")] IReadOnlyList<int> talentIdList,
        [property: JsonPropertyName("fightPropMap")] FightPropMap fightPropMap,
        [property: JsonPropertyName("skillDepotId")] int skillDepotId,
        [property: JsonPropertyName("inherentProudSkillList")] IReadOnlyList<int> inherentProudSkillList,
        [property: JsonPropertyName("skillLevelMap")] SkillLevelMap skillLevelMap,
        [property: JsonPropertyName("equipList")] IReadOnlyList<EquipList> equipList,
        [property: JsonPropertyName("fetterInfo")] FetterInfo fetterInfo,
        [property: JsonPropertyName("proudSkillExtraLevelMap")] ProudSkillExtraLevelMap proudSkillExtraLevelMap,
        [property: JsonPropertyName("costumeId")] int? costumeId
    );

    public record EquipList(
        [property: JsonPropertyName("itemId")] int itemId,
        [property: JsonPropertyName("reliquary")] Reliquary reliquary,
        [property: JsonPropertyName("flat")] Flat flat,
        [property: JsonPropertyName("weapon")] Weapon weapon
    );

    public record FetterInfo(
        [property: JsonPropertyName("expLevel")] int expLevel
    );

    public record FightPropMap(
        [property: JsonPropertyName("1")] double _1,
        [property: JsonPropertyName("2")] double _2,
        [property: JsonPropertyName("3")] double _3,
        [property: JsonPropertyName("4")] double _4,
        [property: JsonPropertyName("5")] double _5,
        [property: JsonPropertyName("6")] double _6,
        [property: JsonPropertyName("7")] double _7,
        [property: JsonPropertyName("8")] double _8,
        [property: JsonPropertyName("20")] double CR,
        [property: JsonPropertyName("21")] int _21,
        [property: JsonPropertyName("22")] double CD,
        [property: JsonPropertyName("23")] double ER,
        [property: JsonPropertyName("26")] double HealingBonus,
        [property: JsonPropertyName("27")] int _27,
        [property: JsonPropertyName("28")] double EM,
        [property: JsonPropertyName("29")] int _29,
        [property: JsonPropertyName("30")] double PhysDMG,
        [property: JsonPropertyName("40")] double PyroDMG,
        [property: JsonPropertyName("41")] double ElectroDMG,
        [property: JsonPropertyName("42")] double HydroDMG,
        [property: JsonPropertyName("43")] double DendroDMG,
        [property: JsonPropertyName("44")] double AnemoDMG,
        [property: JsonPropertyName("45")] double GeoDMG,
        [property: JsonPropertyName("46")] double CryoDMG,
        [property: JsonPropertyName("50")] int _50,
        [property: JsonPropertyName("51")] int _51,
        [property: JsonPropertyName("52")] int _52,
        [property: JsonPropertyName("53")] int _53,
        [property: JsonPropertyName("54")] int _54,
        [property: JsonPropertyName("55")] int _55,
        [property: JsonPropertyName("56")] int _56,
        [property: JsonPropertyName("75")] int _75,
        [property: JsonPropertyName("1005")] int _1005,
        [property: JsonPropertyName("1010")] double _1010,
        [property: JsonPropertyName("2000")] double MaxHP,
        [property: JsonPropertyName("2001")] double ATK,
        [property: JsonPropertyName("2002")] double DEF,
        [property: JsonPropertyName("2003")] int _2003,
        [property: JsonPropertyName("3045")] int _3045,
        [property: JsonPropertyName("3046")] int _3046,
        [property: JsonPropertyName("72")] int? _72,
        [property: JsonPropertyName("1002")] double? _1002,
        [property: JsonPropertyName("70")] int? _70,
        [property: JsonPropertyName("1000")] int? _1000,
        [property: JsonPropertyName("9")] double? _9,
        [property: JsonPropertyName("71")] int? _71,
        [property: JsonPropertyName("1001")] int? _1001
    );

    public record Flat(
        [property: JsonPropertyName("nameTextMapHash")] string nameTextMapHash,
        [property: JsonPropertyName("setNameTextMapHash")] string setNameTextMapHash,
        [property: JsonPropertyName("rankLevel")] int rankLevel,
        [property: JsonPropertyName("reliquaryMainstat")] ReliquaryMainstat reliquaryMainstat,
        [property: JsonPropertyName("reliquarySubstats")] IReadOnlyList<ReliquarySubstat> reliquarySubstats,
        [property: JsonPropertyName("itemType")] string itemType,
        [property: JsonPropertyName("icon")] string icon,
        [property: JsonPropertyName("equipType")] string equipType,
        [property: JsonPropertyName("weaponStats")] IReadOnlyList<WeaponStat> weaponStats
    );

    public record PlayerInfo(
        [property: JsonPropertyName("nickname")] string nickname,
        [property: JsonPropertyName("level")] int level,
        [property: JsonPropertyName("signature")] string signature,
        [property: JsonPropertyName("worldLevel")] int worldLevel,
        [property: JsonPropertyName("nameCardId")] int nameCardId,
        [property: JsonPropertyName("finishAchievementNum")] int finishAchievementNum,
        [property: JsonPropertyName("towerFloorIndex")] int towerFloorIndex,
        [property: JsonPropertyName("towerLevelIndex")] int towerLevelIndex,
        [property: JsonPropertyName("showAvatarInfoList")] IReadOnlyList<ShowAvatarInfoList> showAvatarInfoList,
        [property: JsonPropertyName("showNameCardIdList")] IReadOnlyList<int> showNameCardIdList,
        [property: JsonPropertyName("profilePicture")] ProfilePicture profilePicture
    );

    public record ProfilePicture(
        [property: JsonPropertyName("avatarId")] int avatarId
    );

    public record PropMap(
        [property: JsonPropertyName("1001")] _1001 _1001,
        [property: JsonPropertyName("1002")] _1002 _1002,
        [property: JsonPropertyName("1003")] _1003 _1003,
        [property: JsonPropertyName("1004")] _1004 _1004,
        [property: JsonPropertyName("4001")] _4001 _4001,
        [property: JsonPropertyName("10010")] _10010 _10010
    );

    public record ProudSkillExtraLevelMap(
        [property: JsonPropertyName("2332")] int _2332,
        [property: JsonPropertyName("2339")] int _2339,
        [property: JsonPropertyName("2532")] int? _2532,
        [property: JsonPropertyName("2539")] int? _2539,
        [property: JsonPropertyName("3132")] int? _3132,
        [property: JsonPropertyName("3139")] int? _3139
    );

    public record Reliquary(
        [property: JsonPropertyName("level")] int level,
        [property: JsonPropertyName("mainPropId")] int mainPropId,
        [property: JsonPropertyName("appendPropIdList")] IReadOnlyList<int> appendPropIdList
    );

    public record ReliquaryMainstat(
        [property: JsonPropertyName("mainPropId")] string mainPropId,
        [property: JsonPropertyName("statValue")] double statValue
    );

    public record ReliquarySubstat(
        [property: JsonPropertyName("appendPropId")] string appendPropId,
        [property: JsonPropertyName("statValue")] double statValue
    );

    public record EnkaData(
        [property: JsonPropertyName("playerInfo")] PlayerInfo playerInfo,
        [property: JsonPropertyName("avatarInfoList")] IReadOnlyList<AvatarInfoList> avatarInfoList,
        [property: JsonPropertyName("ttl")] int ttl,
        [property: JsonPropertyName("uid")] string uid
    );

    public record ShowAvatarInfoList(
        [property: JsonPropertyName("avatarId")] int avatarId,
        [property: JsonPropertyName("level")] int level,
        [property: JsonPropertyName("costumeId")] int? costumeId
    );

    public record SkillLevelMap(
        [property: JsonPropertyName("10371")] int _10371,
        [property: JsonPropertyName("10372")] int _10372,
        [property: JsonPropertyName("10373")] int _10373,
        [property: JsonPropertyName("10606")] int? _10606,
        [property: JsonPropertyName("10607")] int? _10607,
        [property: JsonPropertyName("10610")] int? _10610,
        [property: JsonPropertyName("10491")] int? _10491,
        [property: JsonPropertyName("10492")] int? _10492,
        [property: JsonPropertyName("10495")] int? _10495,
        [property: JsonPropertyName("10541")] int? _10541,
        [property: JsonPropertyName("10542")] int? _10542,
        [property: JsonPropertyName("10545")] int? _10545,
        [property: JsonPropertyName("10581")] int? _10581,
        [property: JsonPropertyName("10582")] int? _10582,
        [property: JsonPropertyName("10585")] int? _10585,
        [property: JsonPropertyName("10231")] int? _10231,
        [property: JsonPropertyName("10232")] int? _10232,
        [property: JsonPropertyName("10235")] int? _10235,
        [property: JsonPropertyName("10381")] int? _10381,
        [property: JsonPropertyName("10382")] int? _10382,
        [property: JsonPropertyName("10385")] int? _10385,
        [property: JsonPropertyName("10311")] int? _10311,
        [property: JsonPropertyName("10312")] int? _10312,
        [property: JsonPropertyName("10313")] int? _10313
    );

    public record Weapon(
        [property: JsonPropertyName("level")] int level,
        [property: JsonPropertyName("promoteLevel")] int promoteLevel,
        [property: JsonPropertyName("affixMap")] AffixMap affixMap
    );

    public record WeaponStat(
        [property: JsonPropertyName("appendPropId")] string appendPropId,
        [property: JsonPropertyName("statValue")] double statValue
    );

