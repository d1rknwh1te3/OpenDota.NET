namespace OpenDotaDotNet.Routes.Heroes;

/// <inheritdoc />
public class HeroesEndpoint(Requester requester) : IHeroesEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<Hero>?> GetHeroesAsync() =>
		requester.GetResponseAsync<IEnumerable<Hero>>("heroes");

	/// <inheritdoc />
	public Task<IEnumerable<HeroMatch>?> GetHeroMatchesAsync(int heroId) =>
		requester.GetResponseAsync<IEnumerable<HeroMatch>>($"heroes/{heroId}/matches");

	/// <inheritdoc />
	public Task<IEnumerable<HeroMatchup>?> GetHeroMatchupsAsync(int heroId) =>
		requester.GetResponseAsync<IEnumerable<HeroMatchup>>($"heroes/{heroId}/matchups");

	/// <inheritdoc />
	public Task<IEnumerable<HeroDuration>?> GetHeroDurationsAsync(int heroId) =>
		requester.GetResponseAsync<IEnumerable<HeroDuration>>($"heroes/{heroId}/durations");

	/// <inheritdoc />
	public Task<IEnumerable<HeroPlayer>?> GetHeroPlayersAsync(int heroId) =>
		requester.GetResponseAsync<IEnumerable<HeroPlayer>>($"heroes/{heroId}/players");

	/// <inheritdoc />
	public Task<IEnumerable<HeroItemPopularity>?> GetHeroItemPopularityAsync(int heroId) => 
		requester.GetResponseAsync<IEnumerable<HeroItemPopularity>>($"heroes/{heroId}/itemPopularity");
}