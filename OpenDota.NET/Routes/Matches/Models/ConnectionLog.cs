namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a connection log
/// </summary>
public class ConnectionLog
{
	/// <summary>
	/// Gets event that occurred (connect, reconnect, disconnect) TODO: check if can create enum
	/// </summary>
	[JsonPropertyName("event")]
	public string Event { get; init; } = string.Empty;

	/// <summary>
	/// Gets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long PlayerSlot { get; init; }

	/// <summary>
	/// Gets which slot. 
	/// </summary>
	[JsonPropertyName("slot")]
	public long Slot { get; init; }

	/// <summary>
	/// Gets game time in seconds the event ocurred
	/// </summary>
	[JsonPropertyName("time")]
	public long Time { get; init; }

	/// <summary>
	/// Gets type of log (should always be "connection_log")
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; init; }
}