using System.Text.Json.Serialization;
using System.Runtime.Serialization;
namespace MatchMaker.Entities;

public class GameMatch
{
    public int Id { get; set; }
    public required string Player1 { get; set; }
    public string? Player2 { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public MatchState State { get; set; }
}

public enum MatchState
{
    [EnumMember(Value = "WaitingForOpponent")]
    WaitingForOpponent,
    [EnumMember(Value = "MatchFound")]
    MatchFound,
    [EnumMember(Value = "GameReady")]
    GameReady
}