namespace OpenDotaDotNet.Routes.Teams.Models;

/// <summary>
/// Represents a team hero.
/// </summary>
public class TeamHero
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	/// <summary>
	/// Gets or sets hero name, e.g. 'Anti-Mage'.
	/// </summary>
	[JsonProperty("localized_name")]
	public required string LocalizedName { get; set; }

	/// <summary>
	/// Gets or sets number of games played.
	/// </summary>
	[JsonProperty("games_played")]
	public int GamesPlayed { get; set; }

	/// <summary>
	/// Gets or sets number of wins.
	/// </summary>
	[JsonProperty("wins")]
	public int Wins { get; set; }
}