namespace OpenDotaDotNet.Routes.Matches.Models;

public class BuybackLog
{
	/// <summary>
	/// Gets time in seconds the buyback occurred
	/// </summary>
	[JsonPropertyName("time")]
	public int Time { get; init; }

	/// <summary>
	/// Gets which slot the buyback occurred
	/// </summary>
	[JsonPropertyName("slot")]
	public long Slot { get; init; }

	/// <summary>
	/// Gets type of action (buyback_log)
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; init; } = string.Empty;

	/// <summary>
	/// Gets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long PlayerSlot { get; init; }
}