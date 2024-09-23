using OpenDotaDotNet.Routes.Rankings.Models;

namespace OpenDotaDotNet.Routes.Rankings;

public class RankingsEndpoint(Requester requester) : IRankingsEndpoint
{
	/// <inheritdoc />
	public Task<HeroRanking?> GetHeroRankingsAsync(int heroId) =>
		requester.GetResponseAsync<HeroRanking>(
			"rankings",
			[$"hero_id={heroId}"]);
}