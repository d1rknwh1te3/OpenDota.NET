namespace OpenDotaDotNet.Routes.Matches.Models;

public class BuybackLog
{
	// Time in seconds the buyback occurred
	[JsonProperty("time")]
	public int Time { get; set; }

	[JsonProperty("slot")]
	public long Slot { get; set; }

	// Type of action (buyback_log)
	[JsonProperty("type")]
	public string Type { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonProperty("player_slot")]
	public long PlayerSlot { get; set; }
}