namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Contains information about an objective.
/// </summary>
public class Objective
{
	// Time (in seconds) when the objective happened
	[JsonPropertyName("time")]
	public long Time { get; set; }

	// Type of objective (courier kill, tower kill, first blood, etc)
	[JsonPropertyName("type")]
	public string Type { get; set; }

	[JsonPropertyName("slot")]
	public long? Slot { get; set; }

	// Returns integers and strings [need a full list]
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long? PlayerSlot { get; set; }

	// Which unit got the objective
	[JsonPropertyName("unit")]
	public string Unit { get; set; }

	// Which team got the objective
	[JsonPropertyName("team")]
	public long? Team { get; set; }
}