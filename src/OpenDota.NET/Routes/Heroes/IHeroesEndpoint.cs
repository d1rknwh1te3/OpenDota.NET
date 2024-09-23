namespace OpenDotaDotNet.Routes.Heroes;

/// <summary>
/// Represents a heroes endpoint. 
/// </summary>
public interface IHeroesEndpoint
{
	/// <summary>
	/// Get hero data. GET /heroes.
	/// </summary>
	/// <returns>Hero data.</returns>
	Task<IEnumerable<Hero>?> GetHeroesAsync();

	/// <summary>
	/// Get recent matches with a hero. GET /heroes/{hero_id}/matches.
	/// </summary>
	/// <param name="heroId"></param>
	/// <returns>Recent matches with a hero.</returns>
	Task<IEnumerable<HeroMatch>?> GetHeroMatchesAsync(int heroId);

	/// <summary>
	/// Get results against other heroes for a hero. GET /heroes/{hero_id}/matchups.
	/// </summary>
	/// <param name="heroId"></param>
	/// <returns>Results against other heroes for a hero.</returns>
	Task<IEnumerable<HeroMatchup>?> GetHeroMatchupsAsync(int heroId);

	/// <summary>
	/// Get hero performance over a range of match durations. GET /heroes/{hero_id}/durations.
	/// </summary>
	/// <param name="heroId"></param>
	/// <returns>Hero performance over a range of match durations.</returns>
	Task<IEnumerable<HeroDuration>?> GetHeroDurationsAsync(int heroId);

	/// <summary>
	/// Get players who have played this hero. GET /heroes/{hero_id}/players.
	/// </summary>
	/// <param name="heroId"></param>
	/// <returns>Players who have played this hero.</returns>
	Task<IEnumerable<HeroPlayer>?> GetHeroPlayersAsync(int heroId);

	/// <summary>
	/// Get item popularity of hero categoried by start, early, mid and late game, analyzed from professional games. GET /heroes/{hero_id}/itemPopularity.
	/// </summary>
	/// <param name="heroId">The hero identifier.</param>
	/// <returns></returns>
	Task<IEnumerable<HeroItemPopularity>?> GetHeroItemPopularityAsync(int heroId);
}