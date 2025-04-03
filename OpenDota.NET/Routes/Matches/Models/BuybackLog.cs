namespace OpenDotaDotNet.Routes.Matches.Models;

public class BuybackLog
{
	// Time in seconds the buyback occurred
	[JsonPropertyName("time")]
	public int Time { get; set; }

	[JsonPropertyName("slot")]
	public long Slot { get; set; }

	// Type of action (buyback_log)
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long PlayerSlot { get; set; }
}