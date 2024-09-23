namespace OpenDotaDotNet.Routes.HeroStats;

/// <summary>
/// Hero stats endpoint.
/// </summary>
public interface IHeroStatsEndpoint
{
	/// <summary>
	/// Get stats about hero performance in recent matches.
	/// </summary>
	/// <returns>Stats about hero performance in recent matches.</returns>
	Task<IEnumerable<HeroStats>?> GetHeroStatsAsync();
}