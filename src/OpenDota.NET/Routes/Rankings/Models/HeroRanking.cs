namespace OpenDotaDotNet.Routes.Rankings.Models;

/// <summary>
/// Represents a hero ranking.
/// </summary>
public class HeroRanking
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonProperty("hero_id")]
	public long HeroId { get; set; }

	[JsonProperty("rankings")]
	public IEnumerable<RankingPlayer> Rankings { get; set; }
}