namespace OpenDotaDotNet.Routes.Heroes.Models;

/// <summary>
/// Represents a hero player.
/// </summary>
public class HeroPlayer
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public long? AccountId { get; set; }

	/// <summary>
	/// Gets or sets number of games played on the hero.
	/// </summary>
	[JsonProperty("games_played")]
	public long GamesPlayed { get; set; }

	/// <summary>
	/// Gets or sets number of games won.
	/// </summary>
	[JsonProperty("wins")]
	public long Wins { get; set; }
}