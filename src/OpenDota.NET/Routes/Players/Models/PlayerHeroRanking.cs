namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents a player's hero ranking
/// </summary>
public class PlayerHeroRanking
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonProperty("hero_id")]
	public long HeroId { get; set; }

	[JsonProperty("score")]
	public double Score { get; set; }

	[JsonProperty("percent_rank")]
	public double PercentRank { get; set; }

	[JsonProperty("card")]
	public long Card { get; set; }
}