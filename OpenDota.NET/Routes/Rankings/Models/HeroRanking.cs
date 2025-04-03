namespace OpenDotaDotNet.Routes.Rankings.Models;

/// <summary>
/// Represents a hero ranking.
/// </summary>
public class HeroRanking
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public long HeroId { get; set; }

	[JsonPropertyName("rankings")]
	public IEnumerable<RankingPlayer> Rankings { get; set; }
}