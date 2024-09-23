namespace OpenDotaDotNet.Routes.Rankings.Models;

public class HeroRanking
{
	[JsonProperty("hero_id")]
	public long HeroId { get; set; }

	[JsonProperty("rankings")]
	public IEnumerable<RankingPlayer> Rankings { get; set; }
}