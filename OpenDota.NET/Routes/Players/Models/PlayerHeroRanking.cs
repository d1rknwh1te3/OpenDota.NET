namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents a player's hero ranking
/// </summary>
public class PlayerHeroRanking
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public long HeroId { get; set; }

	[JsonPropertyName("score")]
	public double Score { get; set; }

	[JsonPropertyName("percent_rank")]
	public double PercentRank { get; set; }

	[JsonPropertyName("card")]
	public long Card { get; set; }
}