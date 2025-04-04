namespace OpenDotaDotNet.Routes.Heroes;

/// <inheritdoc />
public class HeroesEndpoint(Requester requester) : IHeroesEndpoint
{
	/// <inheritdoc />
	public Task<List<Hero>?> GetHeroesAsync() =>
		requester.GetResponseAsync<List<Hero>>("heroes");

	/// <inheritdoc />
	public Task<List<HeroMatch>?> GetHeroMatchesAsync(int heroId) =>
		requester.GetResponseAsync<List<HeroMatch>>($"heroes/{heroId}/matches");

	/// <inheritdoc />
	public Task<List<HeroMatchup>?> GetHeroMatchupsAsync(int heroId) =>
		requester.GetResponseAsync<List<HeroMatchup>>($"heroes/{heroId}/matchups");

	/// <inheritdoc />
	public Task<List<HeroDuration>?> GetHeroDurationsAsync(int heroId) =>
		requester.GetResponseAsync<List<HeroDuration>>($"heroes/{heroId}/durations");

	/// <inheritdoc />
	public Task<List<HeroPlayer>?> GetHeroPlayersAsync(int heroId) =>
		requester.GetResponseAsync<List<HeroPlayer>>($"heroes/{heroId}/players");

	/// <inheritdoc />
	public Task<List<HeroItemPopularity>?> GetHeroItemPopularityAsync(int heroId) => 
		requester.GetResponseAsync<List<HeroItemPopularity>>($"heroes/{heroId}/itemPopularity");
}