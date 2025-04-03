namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player match hero.
/// </summary>
public class PlayerMatchHero
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public long? AccountId { get; set; }

	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public long HeroId { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long PlayerSlot { get; set; }
}