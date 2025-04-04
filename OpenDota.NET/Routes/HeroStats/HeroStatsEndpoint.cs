namespace OpenDotaDotNet.Routes.HeroStats;

/// <inheritdoc />
public class HeroStatsEndpoint(Requester requester) : IHeroStatsEndpoint
{
	/// <inheritdoc />
	public Task<List<Models.HeroStats>?> GetHeroStatsAsync() =>
		requester.GetResponseAsync<List<Models.HeroStats>>("heroStats");
}