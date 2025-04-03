namespace OpenDotaDotNet.Routes.Heroes.Models;

/// <summary>
/// Represents a hero matchup.
/// </summary>
public class HeroMatchup
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public long HeroId { get; set; }

	/// <summary>
	/// Gets or sets number of games played.
	/// </summary>
	[JsonPropertyName("games_played")]
	public long GamesPlayed { get; set; }

	/// <summary>
	/// Gets or sets number of wins.
	/// </summary>
	[JsonPropertyName("wins")]
	public long Wins { get; set; }
}