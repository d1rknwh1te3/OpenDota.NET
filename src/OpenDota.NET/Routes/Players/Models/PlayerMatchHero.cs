namespace OpenDotaDotNet.Routes.Players.Models;

public class PlayerMatchHero
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public long? AccountId { get; set; }

	[JsonProperty("hero_id")]
	public long HeroId { get; set; }

	[JsonProperty("player_slot")]
	public long PlayerSlot { get; set; }
}