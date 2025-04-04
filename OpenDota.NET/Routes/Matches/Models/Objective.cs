namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Contains information about an objective.
/// </summary>
public class Objective
{
	/// <summary>
	/// Gets time (in seconds) when the objective happened
	/// </summary>
	[JsonPropertyName("time")]
	public long? Time { get; init; }

	/// <summary>
	/// Gets type of objective (courier kill, tower kill, first blood, etc)
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; init; } = string.Empty;

	/// <summary>
	/// Gets which slot the objective happened in
	/// </summary>
	[JsonPropertyName("slot")]
	public long? Slot { get; init; }

	/// <summary>
	/// Gets integers and strings TODO: [need a full list]
	/// </summary>
	[JsonPropertyName("key")]
	public object? Key { get; init; }

	/// <summary>
	/// Gets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long? PlayerSlot { get; init; }

	/// <summary>
	/// Gets which unit got the objective
	/// </summary>
	[JsonPropertyName("unit")]
	public string Unit { get; init; } = string.Empty;

	/// <summary>
	/// Gets which team got the objective
	/// </summary>
	[JsonPropertyName("team")]
	public long? Team { get; init; }
}