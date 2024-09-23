namespace OpenDotaDotNet.Routes.HeroStats;

public class HeroStatsEndpoint(Requester requester) : IHeroStatsEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<Models.HeroStats>?> GetHeroStatsAsync() =>
		requester.GetResponseAsync<IEnumerable<Models.HeroStats>>("heroStats");
}