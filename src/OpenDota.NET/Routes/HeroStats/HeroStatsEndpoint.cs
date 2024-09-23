namespace OpenDotaDotNet.Routes.HeroStats;

public class HeroStatsEndpoint(Requester requester) : IHeroStatsEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<HeroStats>?> GetHeroStatsAsync() =>
		requester.GetResponseAsync<IEnumerable<HeroStats>>("heroStats");
}