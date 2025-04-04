namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player count.
/// </summary>
public class PlayerCount
{
	/// <summary>
	/// Gets integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned.
	/// </summary>
	[JsonPropertyName("leaver_status")]
	public Dictionary<string, PlayerCountStats> LeaverStatus { get; init; } = new();

	/// <summary>
	/// Gets integer corresponding to game mode played.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
	/// </summary>
	[JsonPropertyName("game_mode")]
	public Dictionary<string, PlayerCountStats> GameMode { get; init; } = new();

	/// <summary>
	/// Gets integer corresponding to lobby type of match.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
	/// </summary>
	[JsonPropertyName("lobby_type")]
	public Dictionary<string, PlayerCountStats> LobbyType { get; init; } = new();

	/// <summary>
	/// Gets lane_role.
	/// </summary>
	[JsonPropertyName("lane_role")]
	public Dictionary<string, PlayerCountStats> LaneRole { get; init; } = new();

	/// <summary>
	/// Gets integer corresponding to the region the game was played on.
	/// </summary>
	[JsonPropertyName("region")]
	public Dictionary<string, PlayerCountStats> Region { get; init; } = new();

	/// <summary>
	/// Gets patch.
	/// </summary>
	[JsonPropertyName("patch")]
	public Dictionary<string, PlayerCountStats> Patch { get; init; } = new();

	/// <summary>
	/// Gets radiant/dire stats.
	/// </summary>
	[JsonPropertyName("is_radiant")]
	public Dictionary<string, PlayerCountStats> IsRadiant { get; init; } = new();
}