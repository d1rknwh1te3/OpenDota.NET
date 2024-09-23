namespace OpenDotaDotNet.Routes.FindMatches;

/// <summary>
/// Find matches endpoint.
/// </summary>
public interface IFindMatchesEndpoint
{
	/// <summary>
	/// Finds matches by heroes played (currently includes matches played after April 2019).
	/// </summary>
	/// <param name="teamA"></param>
	/// <param name="teamB"></param>
	/// <returns>Matches by heroes played.</returns>
	Task<IEnumerable<FindMatch>?> FindMatchesByHeroesPlayedAsync(
		List<int>? teamA = null,
		List<int>? teamB = null);
}