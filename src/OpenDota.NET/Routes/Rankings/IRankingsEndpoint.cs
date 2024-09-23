namespace OpenDotaDotNet.Routes.Rankings;

public interface IRankingsEndpoint
{
	/// <summary>
	/// Gets top players by hero.
	/// </summary>
	/// <param name="heroId"></param>
	/// <returns>Top players by hero.</returns>
	Task<HeroRanking?> GetHeroRankingsAsync(int heroId);
}