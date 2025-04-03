namespace OpenDotaDotNet.Routes.Teams.Models;

/// <summary>
/// Represents a team hero.
/// </summary>
public class TeamHero
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; set; }

	/// <summary>
	/// Gets or sets hero name, e.g. 'Anti-Mage'.
	/// </summary>
	[JsonPropertyName("localized_name")]
	public required string LocalizedName { get; set; }

	/// <summary>
	/// Gets or sets number of games played.
	/// </summary>
	[JsonPropertyName("games_played")]
	public int GamesPlayed { get; set; }

	/// <summary>
	/// Gets or sets number of wins.
	/// </summary>
	[JsonPropertyName("wins")]
	public int Wins { get; set; }
}