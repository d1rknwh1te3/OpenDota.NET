namespace OpenDotaDotNet.Endpoints;

public class RankingsEndpoint(Requester requester) : IRankingsEndpoint
{
	/// <inheritdoc />
	public Task<HeroRanking?> GetHeroRankingsAsync(int heroId) =>
		requester.GetResponseAsync<HeroRanking>(
			"rankings",
			[$"hero_id={heroId}"]);
}