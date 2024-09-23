namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player match hero.
/// </summary>
public class PlayerMatchHero
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
	public long HeroId { get; set; }

	[JsonProperty("player_slot")]
	public long PlayerSlot { get; set; }
}