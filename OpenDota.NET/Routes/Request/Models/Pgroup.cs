namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a player group.
/// </summary>
public class Pgroup
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public long? AccountId { get; set; }

	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonProperty("player_slot")]
	public int PlayerSlot { get; set; }
}